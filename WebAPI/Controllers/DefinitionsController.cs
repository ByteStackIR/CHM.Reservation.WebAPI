using Azure.Core;
using Contracts.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefinitionsController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public readonly IDefinitionsService _definitionsService;

        public DefinitionsController(IConfiguration configuration, IDefinitionsService definitionsService)
        {
            _configuration = configuration;
            _definitionsService = definitionsService;
        }

        /// <summary>
        /// گرفتن لیست دفینیشن ها مثل شهر ها و ... 
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetDefinitions(Guid parentId)
        {
            try
            {
                var result = await _definitionsService.GetDefinitionsAsync(parentId);
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

    }
}
