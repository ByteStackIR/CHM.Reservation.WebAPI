using Contracts.IService;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using WebAPI.ActionFilters;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuthenticationService _Authenticationservice;
        private readonly IConfiguration _configuration;
        private readonly IRelativesService _relativesService;
        private readonly IUserCompanyService _userCompany;

        public UsersController(
            IAuthenticationService Authenticationservice,
            IUserCompanyService userCompany,
            IRelativesService relativesService
        )
        {
            _Authenticationservice = Authenticationservice;
            _relativesService = relativesService;
            _userCompany = userCompany;
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser(
            [FromBody] UserForRegistrationDto userForRegistration
        )
        {
            var result = await _Authenticationservice.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            // افزودن اطلاعات کاربر با نسب خود به جدول اطرافیان
            var selfRelatives = await _relativesService.AddSelf(userForRegistration);
            // ارتباط با شرکت
            await _userCompany.AddUserToCompany(
                Guid.Parse(selfRelatives.UserId),
                userForRegistration.CompanyId,
                userForRegistration.PersonnelCode
            );

            return StatusCode(201);
        }
    }
}
