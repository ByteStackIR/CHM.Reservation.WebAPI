using Contracts.IService;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;
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


        [HttpPost("refresh")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _Authenticationservice.RefreshToken(tokenDto);
            return Ok(tokenDtoToReturn);
        }
    }
}
