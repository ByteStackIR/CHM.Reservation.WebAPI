namespace WebAPI.Controllers
{
    using Contracts.IService;
    using Entities.Constant;
    using Entities.DataTransferObjects;
    using Features.CustomRequest;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using WebAPI.ActionFilters;

    [Route("api/[controller]")]
    [ApiController]
    // [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _UserService;

        private readonly IConfiguration _configuration;

        public UsersController(IUsersService UserService)
        {
            _UserService = UserService;
        }

        /// <summary>
        /// دریافت لیست تمامی کاربران ثبت شده در برنامه به همراه آیدی شرکت
        /// </summary>
        /// <param name="Dto"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        // [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllUsers([FromBody] AdminUsersTableRequest Dto)
        {
            // TODO ارسال تعداد و مشخصات اعضای زیر مجموعه
            var users = await _UserService.GetAllUsersAsAdmin(Dto);

            return Ok(users);
        }

        /// <summary>
        /// ثبت کاربر جدید
        /// </summary>
        /// <param name="userForRegistration"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        //[Authorize(Roles = RolesNamesConstant.Administrator)]
        public async Task<IActionResult> RegisterUser(
            [FromBody] UserForRegistrationDto userForRegistration
        )
        {
            var result = await _UserService.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }

        /// <summary>
        /// دریافت اطلاعات کاربر از طریق آیدی
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetUserById(Guid Id)
        {
            var res = await _UserService.GetUserById(Id);
            return Ok(res);
        }

        /// <summary>
        /// آپدیت کاربر
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateUserAsAdmin([FromBody] UserUpdateDto dto)
        {
            if (base.User.IsInRole(RolesNamesConstant.Administrator))
                await _UserService.UpdateUserAsAdmin(dto);
            else
                await _UserService.UpdateUserAsCompany(dto);

            return NoContent();
        }
    }
}
