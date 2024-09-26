using Contracts.IService;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;
using System.Diagnostics.Contracts;
using WebAPI.ActionFilters;

namespace WebAPI.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly Contracts.IService.IAuthenticationService _Authenticationservice;
        private readonly IConfiguration _configuration;


        public AuthenticationController( Contracts.IService.IAuthenticationService Authenticationservice) { 
            _Authenticationservice = Authenticationservice;

        
        }

      



        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _Authenticationservice.ValidateUser(user))
                return Unauthorized();
            var tokenDto = await _Authenticationservice.CreateToken(populateExp: true);
            return Ok(tokenDto);
        }

        [HttpPost("LoginByOTP")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginByOTP([FromBody] UserForAuthenticationDto user)
        {
            var res = await _Authenticationservice.GenerateUserOTP(user.PhoneNumber, user.IdentityCode);


            // var tokenDto = await _Authenticationservice.CreateToken(populateExp: true);
            return Ok(res);
        }


        [HttpPost("VerifyLoginOTP")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> VerifyLoginOTP([FromBody] UserForAuthenticationDto user)
        {
            if (user.PhoneNumber is null)
                throw new ArgumentNullException(nameof(user.PhoneNumber) + "");

            var result = await _Authenticationservice.VerifyUserOTP(user.PhoneNumber, user.code);

            if (result)
            {
                var tokenDto = await _Authenticationservice.CreateToken(populateExp: true);


                return Ok(tokenDto);
            }

            return Unauthorized();
        }


        [HttpPost("refresh")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _Authenticationservice.RefreshToken(tokenDto);
            return Ok(tokenDtoToReturn);
        }

        


    }
}
