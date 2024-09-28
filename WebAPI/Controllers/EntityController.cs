using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Enum;
using Entities.Models;
using Entities.Utils;
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
        private readonly IAttachmentsService _IAttachmentsService;

        /// <summary>
        /// Constructor of EntityController
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="entitySevice"></param>
        public EntityController(
            IConfiguration configuration,
            IEntityService entityService,
            IAttachmentsService iAttachmentsService
        )
        {
            _configuration = configuration;
            _entityService = entityService;
            _IAttachmentsService = iAttachmentsService;
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
        public async Task<IActionResult> UpdateEntity(
            [FromForm] String Entity,
            [FromForm] FilesDto Images
        )
        {
            try
            {
                EntityDto dto = System.Text.Json.JsonSerializer.Deserialize<EntityDto>(
                    Entity,
                    new System.Text.Json.JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true,
                    }
                );

                if (Images != null && Images.Files.Count != 0)
                {
                    foreach (var File in Images.Files)
                    {
                        if (Guid.TryParse(File.Key, out Guid AttachId))
                        {
                            if (File.DisplayOrder == -1)
                                await _IAttachmentsService.RemoveFromStore(AttachId);
                            else
                            {
                                if (File.File != null)
                                {
                                    string tempName = await FileHelper.SaveFileAsync(
                                        File.File,
                                        FileType.FileTypes[FileTypeEnum.Entities]
                                    );
                                    await _IAttachmentsService.AddToStore(
                                        tempName,
                                        FileType.FileTypes[FileTypeEnum.Entities],
                                        File.File.ContentType,
                                        File.DisplayOrder,
                                        dto.Id.Value
                                    );
                                    await _IAttachmentsService.RemoveFromStore(AttachId);
                                }
                                else
                                    await _IAttachmentsService.UpdateStore(
                                        AttachId,
                                        File.DisplayOrder,
                                        dto.Id.Value
                                    );
                            }
                        }
                        else
                        {
                            if (File.File != null)
                            {
                                string tempName = await FileHelper.SaveFileAsync(
                                    File.File,
                                    FileType.FileTypes[FileTypeEnum.Entities]
                                );
                                await _IAttachmentsService.AddToStore(
                                    tempName,
                                    FileType.FileTypes[FileTypeEnum.Entities],
                                    File.File.ContentType,
                                    File.DisplayOrder,
                                    dto.Id.Value
                                );
                            }
                        }
                    }
                }
                var result = await _entityService.UpdateEntityAsync(dto);
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
        public async Task<IActionResult> AddEntity(
            [FromForm] String Entity,
            [FromForm] FilesDto Images
        )
        {
            try
            {
                EntityDto dto = System.Text.Json.JsonSerializer.Deserialize<EntityDto>(
                    Entity,
                    new System.Text.Json.JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = false,
                    }
                );

                dto.Id = Guid.NewGuid();
                if (Images != null && Images.Files.Count != 0)
                {
                    foreach (var File in Images.Files)
                    {
                        string tempName = await FileHelper.SaveFileAsync(
                            File.File,
                            FileType.FileTypes[FileTypeEnum.Entities]
                        );
                        await _IAttachmentsService.AddToStore(
                            tempName,
                            FileType.FileTypes[FileTypeEnum.Entities],
                            File.File.ContentType,
                            File.DisplayOrder,
                            dto.Id.Value
                        );
                    }
                }
                var createdEntity = await _entityService.AddEntityAsync(dto);
                return CreatedAtAction(
                    nameof(GetEntity),
                    new { id = createdEntity.Id },
                    createdEntity
                );
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
