using Contracts.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseInfoController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IParameterService _parameterService;
        private readonly IRelationsService _relationsService;
        public BaseInfoController(IRelationsService relationsService,ICategoryService categoryService ,IParameterService parameterService)
        {
            _categoryService = categoryService;
            _parameterService = parameterService;
            _relationsService = relationsService;
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

    }
}
