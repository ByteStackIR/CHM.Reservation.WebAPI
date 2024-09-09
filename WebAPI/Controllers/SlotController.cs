using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts.IService;
using Services.Services;
using Features.RequestFeatures;
using Features.CustomRequest;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ISlotService _slotService;

        public SlotController(IConfiguration configuration, ISlotService slotService)
        {
            _configuration = configuration;
            _slotService = slotService;
        }

        /// <summary>
        /// گرفتن تمام اسلات های یک موجودیت خاص همراه با میزان اشغال به صورت صفحه بندی شده
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetPagedAvailableSlots(SlotRequest request)
        {
            try
            {
                var result = await _slotService.GetPagedAvailableSlotsAsync(request);
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
