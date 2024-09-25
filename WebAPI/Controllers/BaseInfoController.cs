using Azure.Core;
using Contracts.IService;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseInfoController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ICompanyService _companyService;
        private readonly IParameterService _parameterService;
        private readonly IRelationsService _relationsService;
        private readonly IUsersService _userService;

        public BaseInfoController(IRelationsService relationsService,ICategoryService categoryService,ICompanyService companyService ,IParameterService parameterService, IUsersService usersService)
        {
            _categoryService = categoryService;
            _companyService = companyService;
            _parameterService = parameterService;
            _relationsService = relationsService;
            _userService = usersService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _categoryService.GetAllCategories());
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRelation()
        {
            return Ok(await _relationsService.GetRelations());
        }

        [HttpGet("[action]/{CategoryId}")]
        public async Task<IActionResult> GetParamtersByCategoryId(Guid CategoryId)
        {
            return Ok(await _parameterService.ParametersByCategoryId(CategoryId));
        }

        /// <summary>
        /// گرفتن تمام شرکت ها به صورت صفحه بندی شده
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetCompaniesAsync(CompanyRequest request)
        {
            try
            {
                var result = await _companyService.GetPagedAllCompanies(request);
                if (result is not null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }




        //TODO : role checking admin
        [HttpPost("[action]")]
        public async Task<IActionResult> GetUsersInRoles(List<string> Roles)
        {
            var res = await _userService.GetUsersByRoles(Roles);

            return Ok(res);
        }

    }
}
