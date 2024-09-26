using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Services.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IEntityService _entityService;

        /// <summary>
        /// Constructor of EntityController
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="entitySevice"></param>
        public EntityController(IConfiguration configuration, IEntityService entityService)
        {
            _configuration = configuration;
            _entityService = entityService;
        }


        /// <summary>
        /// گرفتن یک موجودیت خاص از طریق این اندپوینت انجام میشود.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetEntity(Guid entityId)
        {
            try
            {
                var result = await _entityService.GetEntityByIdAsync(entityId);
               
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

        /// <summary>
        /// گرفتن یک موجودیت خاص از طریق این اندپوینت انجام میشود. -- برای عموم 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetSpecifiedEntity(Guid entityId)
        {
            try
            {
                var result = await _entityService.GetSpecifiedEntityAsync(entityId);

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


        /// <summary>
        /// گرفتن تمام موجودیت هایی که در زمان حال فعال هستند به صورت صفحه بندی شده
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetPagedCurrentEntities(PublicEntitiesTableRequest request)
        {
            try
            {
                var result = await _entityService.GetPagedCurrentEntitiesAsync(request);
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

        [HttpPost("[action]")]
        public async Task<IActionResult> GetEntities(AdminEntitiesTableRequest request)
        {
            try
            {
                var result = await _entityService.GetPagedEntities(request);
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


        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateEntity(EntityDto request)
        {
            try
            {
                var result = await _entityService.UpdateEntityAsync(request);
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

        /// <summary>
        /// برای ساخت یک موجودیت جدید(هتل، تور) از این اندپوینت استفاده می‌شود
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("[action]")]
        public async Task<IActionResult> AddEntity(EntityDto dto)
        {
            try
            {
                var createdEntity = await _entityService.AddEntityAsync(dto);
                return CreatedAtAction(nameof(GetEntity), new { id = createdEntity.Id }, createdEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        /// <summary>
        /// گرفتن یک موجودیت خاص از طریق این اندپوینت انجام میشود.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteEntity([FromBody] Guid entityId)
        {
            try
            {
                await _entityService.DeleteEntityByIdAsync(entityId);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
