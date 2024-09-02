namespace Services.Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Contracts.IService;
    using Entities.DataTransferObjects;
    using Entities.Exceptions;
    using Entities.Models;
    using LoggerService;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using Shared.DataTransferObjects;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using WebAPI.Configuration;

    /// <summary>
    /// Defines the <see cref="AuthenticationService" />
    /// </summary>
    public class AuthenticationService : ServiceBase, IAuthenticationService, IScopeMarker
    {
        /// <summary>
        /// Defines the _userManager
        /// </summary>
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Defines the _configuration
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Defines the _roleManager
        /// </summary>
        private readonly RoleManager<IdentityRole> _roleManager;

        /// <summary>
        /// Defines the _user
        /// </summary>
        private User? _user;

        /// <summary>
        /// Defines the _logger
        /// </summary>
        private ILoggerManager _logger;

        /// <summary>
        /// Defines the Settings
        /// </summary>
        private IOptionsMonitor<JwtSettings> Settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService"/> class.
        /// </summary>
        /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
        /// <param name="repositoryManager">The repositoryManager<see cref="IRepositoryManager"/></param>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <param name="userManager">The userManager<see cref="UserManager{User}"/></param>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/></param>
        /// <param name="roleManager">The roleManager<see cref="RoleManager{IdentityRole}"/></param>
        /// <param name="_settings">The _settings<see cref="IOptionsMonitor{JwtSettings}"/></param>
        /// <param name="accessor">The accessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
        public AuthenticationService(ILoggerManager logger, IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager, IOptionsMonitor<JwtSettings> _settings, IHttpContextAccessor accessor, ISystemContext systemContext) : base(repositoryManager, mapper, accessor, systemContext, logger)
        {
            _logger = logger;
            _userManager = userManager; _configuration = configuration;
            _roleManager = roleManager;
            Settings = _settings;
        }


        /// <summary>
        /// The ValidateUser
        /// </summary>
        /// <param name="userForAuth">The userForAuth<see cref="UserForAuthenticationDto"/></param>
        /// <returns>The <see cref="Task{bool}"/></returns>
        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {

            _user = await _userManager.FindByNameAsync(userForAuth.UserName);
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user,
           userForAuth.Password));
            if (!result)
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong user name or password.");
            return result;
        }

        /// <summary>
        /// The CreateToken
        /// </summary>
        /// <returns>The <see cref="Task{string}"/></returns>
        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        /// <summary>
        /// The GetSigningCredentials
        /// </summary>
        /// <returns>The <see cref="SigningCredentials"/></returns>
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtSettings:Secret").Value);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        /// <summary>
        /// The GetClaims
        /// </summary>
        /// <returns>The <see cref="Task{List{Claim}}"/></returns>
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.UserName) };

            var roles = await _userManager.GetRolesAsync(_user);
            var userRoles = roles.Select(r => new Claim(ClaimTypes.Role, r)).ToArray();
            // var userClaims = await _userManager.GetClaimsAsync(_user).ConfigureAwait(false);
            IList<Claim> roleClaims = new List<Claim>();
            _roleManager.Roles.Where(x => roles.Contains(x.Name)).ToList().ForEach((role) =>
            {
                var claims = _roleManager.GetClaimsAsync(role).Result;
                foreach (var claim in claims)
                {
                    roleClaims.Add(claim);
                }

            });

            claims.AddRange((new[] {
                 new Claim(ClaimTypes.NameIdentifier, _user.Id)
             }.Union(roleClaims).Union(userRoles)).ToList());

            //foreach (var role in roles)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role));
            //}
            return claims;
        }

        /// <summary>
        /// The GenerateTokenOptions
        /// </summary>
        /// <param name="signingCredentials">The signingCredentials<see cref="SigningCredentials"/></param>
        /// <param name="claims">The claims<see cref="List{Claim}"/></param>
        /// <returns>The <see cref="JwtSecurityToken"/></returns>
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
            issuer: jwtSettings["validIssuer"],
            audience: jwtSettings["validAudience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
            signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        /// <summary>
        /// The GenerateRefreshToken
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);

                return Convert.ToBase64String(randomNumber);
            }
        }

        /// <summary>
        /// The GetPrincipalFromExpiredToken
        /// </summary>
        /// <param name="token">The token<see cref="string"/></param>
        /// <returns>The <see cref="ClaimsPrincipal"/></returns>
        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"])),
                ValidateLifetime = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"]
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }
            return principal;
        }

        /// <summary>
        /// The CreateToken
        /// </summary>
        /// <param name="populateExp">The populateExp<see cref="bool"/></param>
        /// <returns>The <see cref="Task{TokenDto}"/></returns>
        public async Task<TokenDto> CreateToken(bool populateExp)
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            var refreshToken = GenerateRefreshToken();
            _user.RefreshToken = refreshToken;
            if (populateExp)
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            await _userManager.UpdateAsync(_user);
            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return new TokenDto(accessToken, refreshToken, _user.RefreshTokenExpiryTime, new(userName: _user.UserName, firstName: _user.FirstName, lastName: _user.LastName, phoneNumber: _user.PhoneNumber));
        }

        /// <summary>
        /// The RefreshToken
        /// </summary>
        /// <param name="tokenDto">The tokenDto<see cref="TokenDto"/></param>
        /// <returns>The <see cref="Task{TokenDto}"/></returns>
        public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
        {
            var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);
            if (user == null || user.RefreshToken != tokenDto.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenBadRequest();

            _user = user;
            return await CreateToken(populateExp: false);
        }
    }

}
