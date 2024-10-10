using Azure.Core;
using Contracts.IService;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        ICreditTransactionService _creditTransactionService;
        ICouponTransactionService _couponTransactionService;
        private readonly IReservationService _reservationService;
        public AccountController(
            ICreditTransactionService creditTransactionService,
            ICouponTransactionService couponTransactionService,
            IReservationService reservationService
        )
        {
            _creditTransactionService = creditTransactionService;
            _couponTransactionService = couponTransactionService;
            _reservationService = reservationService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCredit()
        {
            return Ok(
                new
                {
                    Credit = await _couponTransactionService.GetRemainingCoupon(),
                    Coupon = (await _couponTransactionService.GetRemainingCoupon()) > 0,
                }
            );
        }



        /// <summary>
        /// کارتابل مربوط به گرفتن تمام رزرو های یک کاربر با صفحه بندی
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("User/[action]")]
        public async Task<IActionResult> MyReservation(ReservationRequest_User request)
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
        /// کارتابل مربوط به گرفتن یک رزرو به خصوص کاربر
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("User/[action]/{Id}")]
        public async Task<IActionResult> MyReservationById(Guid Id)
        {
            try
            {
                var result = await _reservationService.GetReservationsOfUserByReservationIdAsync(Id);
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
