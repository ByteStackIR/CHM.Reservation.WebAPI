using Azure.Core;
using Contracts.IService;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        ICreditTransactionService _creditTransactionService;
        ICouponTransactionService _couponTransactionService;

        public AccountController(
            ICreditTransactionService creditTransactionService,
            ICouponTransactionService couponTransactionService
        )
        {
            _creditTransactionService = creditTransactionService;
            _couponTransactionService = couponTransactionService;
        }

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
    }
}
