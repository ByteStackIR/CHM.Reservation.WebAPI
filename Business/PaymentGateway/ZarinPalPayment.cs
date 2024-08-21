using Contracts.IPaymentGateway;
using Entities.DataTransferObjects.PayingDto;
using Entities.DataTransferObjects.PayService.PayPing;
using Entities.DataTransferObjects.PayService.ZarinPal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Services.PaymentGateway
{
    public class ZarinPalPayment : IPaymentGateway
    {
        private Dictionary<string, string?> _ZARINPAL_API { get; set; }
        public ZarinPalPayment(IConfiguration configuration) {
            _ZARINPAL_API = configuration.GetSection("Configuration:ZARINPAL_API").AsEnumerable().ToDictionary(x => x.Key.Replace("Configuration:ZARINPAL_API:", ""), x => x.Value);
        }
        public async Task<toPayResponse> InitilizePayment(BillingDto dto)
        {
            ZarinPal_RequestPayment reqBody = new ZarinPal_RequestPayment()
            {
                description = dto.FullName + " بابت کنسرت " + DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                amount = (int)dto.BillingAmount*10,
                callback_url = dto.ReturnUrl ,
                merchant_id = _ZARINPAL_API["Key"],
                metadata = new()
                {
                    mobile = dto.PhoneNumber,
                    email = null
                }

            };
            Dictionary<string, string> headers = new()
            {
                ["content-type"] = "application/json",
                ["accept"] = "application/json",
            };
            // ساخت کد پرداخت به منظور هدایت به درگاه بانکی
            var res = await RequestHelper.CallApi<ZarinPal_PaymentResult>(_ZARINPAL_API["PAYMENT_URL"], reqBody, headers);

            var result = res.Data;
            if (res.Data == null)
                return null;

            return new() { 
            Amount = dto.BillingAmount*10,
            payCode = res.Data.data.authority,
            PayUrl = _ZARINPAL_API["GOTOIPG_URL"] + res.Data.data.authority
            };


        }

        public async Task<bool> VerifyPayment(toVerifyDto dto)
        {
            ZarinPal_RequestVerify model = new ZarinPal_RequestVerify()
            {
                amount = (int)dto.BillAmount*10,
                authority = dto.refId,
                merchant_id = _ZARINPAL_API["Key"],
            };

            // ساخت کد پرداخت به منظور هدایت به درگاه بانکی
            var res = await RequestHelper.CallApi<ZarinPal_VerifyResult>(_ZARINPAL_API["VERIFY_URL"], model, Headers: new Dictionary<string, string>());

            var code = res.Data?.data.code;

            if (code != null && code == 100 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
