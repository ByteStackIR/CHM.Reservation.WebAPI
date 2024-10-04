using Contracts.IService;
using Entities.DataTransferObjects;
using Features.CustomRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Services;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IConfiguration _cofiguration;
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService, IConfiguration cofiguration)
        {
            _cofiguration = cofiguration;
            _reservationService = reservationService;
        }

        /// <summary>
        /// کارتابل مربوط به گرفتن تمام رزرو های یک کاربر با صفحه بندی
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("User/[action]")]
        public async Task<IActionResult> GetPagedReservationsOfUser(ReservationRequest_User request)
        {
            try
            {
                var result = await _reservationService.GetPagedReservationsOfUserAsync(request);
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
        /// کارتابل مربوط به گرفتن تمام رزرو های یک هتل با صفحه بندی
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Hotel/[action]")]
        public async Task<IActionResult> GetPagedReservationsOfHotel(ReservationRequest_Hotel request)
        {
            try
            {
                var result = await _reservationService.GetPagedReservationsOfHotelAsync(request);
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
        ///  کارتابل مربوط به گرفتن تمام رزرو های مربوط به مجری تور با صفحه بندی
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Execuive/[action]")]
        public async Task<IActionResult> GetPagedReservationOfExecutive(ReservationRequest_Executive request)
        {
            try
            {
                var result = await _reservationService.GetPagedReservationOfExecutiveAsync(request);
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

        [Authorize]
        [HttpPost("[action]")]
        public async Task<IActionResult> AddTemporaryReservation(ReservationCreationDto dto)
        {
            var res = await _reservationService.AddReservation(dto);
            return Ok(res);
        }


        [Authorize]
        [HttpPost("[action]")]
        public async Task<IActionResult> GetTemporaryReservation()
        {
            var res = await _reservationService.GetTemporaryReservation(Guid.Parse(base.User.FindFirstValue(ClaimTypes.NameIdentifier)));
            return Ok(res);
        }

        [Authorize]
        [HttpPost("[action]")]
        public async Task<IActionResult> FinalizeReservation([FromBody] FinalizeReservationDto dto)
        {
            var res = await _reservationService.FinalizeReservation(dto);
            return Ok(res);
        }

        [Authorize]
        [HttpPost("[action]")]
        public async Task<IActionResult> CancelTemporaryReservation([FromBody] FinalizeReservationDto dto)
        {
             await _reservationService.CancelTemporaryReservation(dto.TempoReservationId);
            return NoContent();
        }

    }

 
}
