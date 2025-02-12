using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities;
using Entities.Claims;
using Entities.DataTransferObjects;
using Entities.Enum;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Shared.DataTransferObjects;
using WebAPI.Configuration;
using static Entities.PolicyTypes.PolicyTypes;

namespace Services.Services
{
    public class AuthenticationService : IAuthenticationService, IScopeMarker
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRepositoryManager _repositoryManager;
        private readonly SignInManager<User> _signInManager;
        private User? _user;
        private ILoggerManager _logger;
        private IOptionsMonitor<JwtSettings> Settings;
        private IMapper _mapper;

        public AuthenticationService(
            SignInManager<User> signInManager,
            ILoggerManager logger,
            IRepositoryManager repositoryManager,
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration,
            RoleManager<IdentityRole> roleManager,
            IOptionsMonitor<JwtSettings> _settings
        )
        {
            _logger = logger;
            _userManager = userManager;
            _configuration = configuration;
            _roleManager = roleManager;
            _repositoryManager = repositoryManager;
            Settings = _settings;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            _repositoryManager.BeginTransaction();
            userForRegistration.Password = Guid.NewGuid().ToString();

            IdentityResult result = new();

            if (_userManager.Users.Any(x => x.PhoneNumber == userForRegistration.PhoneNumber))
                return IdentityResult.Failed(
                    new IdentityError()
                    {
                        Code = "DuplicatePhoneNumber",
                        Description = "An existing user with the new PhoneNumber already exists.",
                    }
                );

            userForRegistration.UserName = "U" + userForRegistration.PhoneNumber;

            var user = _mapper.Map<User>(userForRegistration);

            try
            {
                user.TwoFactorEnabled = true;

                result = await _userManager.CreateAsync(user, userForRegistration.Password);

                _user = user;
                // _user =await _userManager.FindByNameAsync(userForRegistration.UserName);


                return result;
            }
            catch (Exception ex)
            {
                _repositoryManager.Rollback();
                return IdentityResult.Failed(
                    new IdentityError() { Code = "unexpctedError", Description = ex.Message }
                );
            }
        }

        //public async Task<OTPResultDto> RegisterOTP(string PhoneNumber)
        //{


        //    if (_user is null)
        //        throw new Exception("USER_NOT_FOUND");

        //    //var code = await _userManager.GenerateChangePhoneNumberTokenAsync(_user,_user.PhoneNumber);

        //    var code = await _userManager.GenerateUserTokenAsync(_user, "CustomSMSConfirmation", "passwordless-auth");

        //    //    var code = await _userManager.GenerateTwoFactorTokenAsync(_user, "Phone");

        //    //  var result = (_user != null && await _userManager.CheckPasswordAsync(_user,userForAuth.Password));
        //    if (code == null)
        //        _logger.LogWarn($"{nameof(ValidateUser)}: Generating token failed.");

        //    OTPResultDto res = new OTPResultDto()
        //    {
        //        IsError = false,
        //        IsSuccesed = true,
        //        PhoneNumber = PhoneNumber,
        //        Code = code,
        //        ExpirationDate = DateTime.Now.AddMinutes(1)
        //    };


        //    return res;
        //}

        //public async Task<bool> VerifyRegisterOTP(string PhoneNumber, string code)
        //{
        //    _user = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == PhoneNumber);
        //    if (_user is null)
        //        throw new Exception("USER_NOT_FOUND");

        //    if (!(await _signInManager.CanSignInAsync(_user)) || _user.LockoutEnabled)
        //    {
        //        throw new Exception(_user.LockoutEnd.HasValue ? _user.LockoutEnd.ToString() : " " + " LOCKOUT_USER");
        //    }

        //    var result = await _userManager.VerifyChangePhoneNumberTokenAsync(_user, code, PhoneNumber);
        //    if (result)
        //    {
        //        _user.PhoneNumberConfirmed = true;
        //        await _userManager.UpdateAsync(_user);
        //    }
        //    return result;
        //}


        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {
            _user = await _userManager.Users.FirstOrDefaultAsync(x =>
                x.PhoneNumber == userForAuth.PhoneNumber
            );
            if (_user is null)
                throw new Exception("USER_NOT_FOUND");

            // var result = await _signInManager.SignInAsync(_user, isPersistent: false, "OTP");

            var result = (
                _user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password)
            );

            if (!result)
                _logger.LogWarn(
                    $"{nameof(ValidateUser)}: Authentication failed. Wrong user name or password."
                );
            return result;
        }

        public async Task<OTPResultDto> GenerateUserOTP(string PhoneNumber, string identityCode)
        {
            _user = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == PhoneNumber);
            if (_user is null)
                throw new Exception("USER_NOT_FOUND");

            if (
                !(await _signInManager.CanSignInAsync(_user))
                || (await _userManager.IsLockedOutAsync(_user))
            )
            {
                throw new Exception(
                    _user.LockoutEnd.HasValue ? _user.LockoutEnd.ToString() : "" + " LOCKOUT_USER"
                );
            }

            // getting the relative record of user with identity code
            var relativeRecord = await _repositoryManager
                .Relatives.FirstOrDefaultAsync(
                    r => r.UserId == _user.Id && r.IdentityCode == identityCode
                 );

            if (relativeRecord == null)
            {
                throw new Exception("IDENTITY_CODE_NOT_FOUND");
            }

            // check if its type is SELF
            var relation = await _repositoryManager
                .Relation.FirstOrDefaultAsync(
                    rel =>
                        rel.Id == relativeRecord.RelationId && rel.Type == (int)RelationType.SELF
                 );

            if (relation == null)
            {
                throw new Exception("NOT_SELF_RELATION");
            }

            var code = await _userManager.GenerateUserTokenAsync(
                _user,
                "CustomSMSConfirmation",
                "passwordless-auth"
            );
            //  _userManager.
            // var code = await _userManager.GenerateTwoFactorTokenAsync(_user, "Phone");

            //  var result = (_user != null && await _userManager.CheckPasswordAsync(_user,userForAuth.Password));
            if (code == null)
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed.");

            OTPResultDto res = new OTPResultDto()
            {
                IsError = false,
                IsSuccesed = true,
                PhoneNumber = PhoneNumber,
                Code = code,
                ExpirationDate = DateTime.Now.AddMinutes(5),
            };

            return res;
        }

        public async Task<bool> VerifyUserOTP(string PhoneNumber, string code)
        {
            _user = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == PhoneNumber);
            if (_user is null)
                throw new Exception("USER_NOT_FOUND");

            if (
                !(await _signInManager.CanSignInAsync(_user))
                || (await _userManager.IsLockedOutAsync(_user))
            )
            {
                throw new Exception(
                    _user.LockoutEnd.HasValue ? _user.LockoutEnd.ToString() : "" + " LOCKOUT_USER"
                );
            }

            var result = await _userManager.VerifyUserTokenAsync(
                _user,
                "CustomSMSConfirmation",
                "passwordless-auth",
                code
            );
            if (result)
            {
                _user.PhoneNumberConfirmed = true;
                await _userManager.UpdateAsync(_user);
            }
            else
            {
                // failure
                await _signInManager.CheckPasswordSignInAsync(
                    _user,
                    Guid.NewGuid().ToString(),
                    true
                );
            }
            return result;
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtSettings:Secret").Value);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.UserName) };

            var roles = await _userManager.GetRolesAsync(_user);
            var userRoles = roles.Select(r => new Claim(ClaimTypes.Role, r.ToUpper())).ToArray();
            // var userClaims = await _userManager.GetClaimsAsync(_user).ConfigureAwait(false);
            IList<Claim> roleClaims = new List<Claim>();
            _roleManager
                .Roles.Where(x => roles.Contains(x.Name))
                .ToList()
                .ForEach(
                    (role) =>
                    {
                        var claims = _roleManager.GetClaimsAsync(role).Result;
                        foreach (var claim in claims)
                        {
                            roleClaims.Add(claim);
                        }
                    }
                );

            claims.AddRange(
                (
                    new[] { new Claim(ClaimTypes.NameIdentifier, _user.Id) }
                        .Union(roleClaims)
                        .Union(userRoles)
                ).ToList()
            );

            claims.Add(
                new Claim(
                    ClaimTypes.UserData,
                    JsonSerializer.Serialize(
                        new UserInfo(
                            _user.Id,
                            _user.FirstName,
                            _user.LastName,
                            _user.PhoneNumber,
                            _user.PhoneNumber
                        )
                    )
                )
            );

            //foreach (var role in roles)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role));
            //}
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(
            SigningCredentials signingCredentials,
            List<Claim> claims
        )
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);

                return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings["Secret"])
                ),
                ValidateLifetime = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"],
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(
                token,
                tokenValidationParameters,
                out securityToken
            );
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (
                jwtSecurityToken == null
                || !jwtSecurityToken.Header.Alg.Equals(
                    SecurityAlgorithms.HmacSha256,
                    StringComparison.InvariantCultureIgnoreCase
                )
            )
            {
                throw new SecurityTokenException("Invalid token");
            }
            return principal;
        }

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
            return new TokenDto(
                accessToken,
                refreshToken,
                _user.RefreshTokenExpiryTime,
                new(
                    id: _user.Id,
                    userName: _user.UserName,
                    firstName: _user.FirstName,
                    lastName: _user.LastName,
                    phoneNumber: _user.PhoneNumber
                )
            );
        }

        public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
        {
            var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);
            if (
                user == null
                || user.RefreshToken != tokenDto.RefreshToken
                || user.RefreshTokenExpiryTime <= DateTime.Now
            )
                throw new RefreshTokenBadRequest();

            _user = user;
            return await CreateToken(populateExp: false);
        }
    }
}
