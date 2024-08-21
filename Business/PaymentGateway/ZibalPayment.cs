using Contracts.IPaymentGateway;
using Entities.DataTransferObjects.PayingDto;
using Entities.DataTransferObjects.PayService.PayPing;
using Entities.DataTransferObjects.PayService.ZarinPal;
using Entities.DataTransferObjects.PayService.Zibal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Services.PaymentGateway
{
    public class ZibalPayment : IPaymentGateway
    {
        private Dictionary<string, string?> _Zibal_API { get; set; }
        public ZibalPayment(IConfiguration configuration) {
            _Zibal_API = configuration.GetSection("Configuration:Zibal_API").AsEnumerable().ToDictionary(x => x.Key.Replace("Configuration:Zibal_API:", ""), x => x.Value);
        }
        public async Task<toPayResponse> InitilizePayment(BillingDto dto)
        {
            Zibal_PaymentRequest reqBody = new Zibal_PaymentRequest()
            {
                description = dto.FullName + " بابت کنسرت " + DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                amount = (int)dto.BillingAmount*10,
                callbackUrl = dto.ReturnUrl ,
                merchant= _Zibal_API["Key"],
               mobile = dto.PhoneNumber

            };
            Dictionary<string, string> headers = new()
            {
                ["content-type"] = "application/json",
                ["accept"] = "application/json",
            };
            // ساخت کد پرداخت به منظور هدایت به درگاه بانکی
            var res = await RequestHelper.CallApi<Zibal_PaymentResult>(_Zibal_API["PAYMENT_URL"], reqBody, headers);

            var result = res.Data;
            if (res.Data == null)
                return null;

            return new() { 
            Amount = dto.BillingAmount*10,
            payCode = res.Data.trackId.ToString(),
            PayUrl = _Zibal_API["GOTOIPG_URL"] + res.Data.trackId
            };


        }

        public async Task<bool> VerifyPayment(toVerifyDto dto)
        {
            Zibal_RequestVerify model = new Zibal_RequestVerify()
            {
                merchant = _Zibal_API["Key"],
                trackId = Convert.ToInt64(dto.refId),
            };

            // ساخت کد پرداخت به منظور هدایت به درگاه بانکی
            var res = await RequestHelper.CallApi<Zibal_VerifyResult>(_Zibal_API["VERIFY_URL"], model, Headers: new Dictionary<string, string>());

            var code = res.Data.Result;

            if (code != null && code == 100)
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
