using Contracts.IService;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IPeriodService _periodService;

        public PeriodController(IPeriodService periodService, IConfiguration configuration)
        {
            _configuration = configuration;
            _periodService = periodService;
        }

        /// <summary>
        /// This Endpoint is used to Cread a new Period model
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> AddPeriod(PeriodDto dto)
        {
            try
            {
                var result = _periodService.AddPeriod(dto);
                if (result is not false)
                {
                    return Ok("Period Added Successfully.");
                }
                else
                {
                    return StatusCode(500, "An Error Occured While Adding New Period");
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// This Endpoint is used to update an existing Period model
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdatePeriod(PeriodDto dto)
        {
            try
            {
                var result = await _periodService.UpdatePeriod(dto);
                if(result is not null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
