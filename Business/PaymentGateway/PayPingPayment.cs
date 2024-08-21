using Contracts.IPaymentGateway;
using Entities.DataTransferObjects.PayingDto;
using Entities.DataTransferObjects.PayService.PayPing;
using Entities.Enum;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PaymentGateway
{
    public class PayPingPayment : IPaymentGateway
    {

        private Dictionary<string, string?> _PAYPING_API { get; set; }
        public PayPingPayment(IConfiguration configuration)
        {
            _PAYPING_API = configuration.GetSection("Configuration:PAYPAING_API").AsEnumerable().ToDictionary(x => x.Key.Replace("Configuration:PAYPAING_API:", ""), x => x.Value);
        }

        public async Task<toPayResponse> InitilizePayment(BillingDto dto)
        {
            PayPing_RequestPayment model = new PayPing_RequestPayment()
            {
                Amount = (int)dto.BillingAmount,
                PayerName = dto.FullName,
                ReturnUrl = dto.ReturnUrl,
                Description = dto.FullName + " بابت کنسرت " + DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                ClientRefId = dto.TransactionId.ToString()
            };

            string accessToken = _PAYPING_API["Key"];
            Dictionary<string, string> headers =
            new()
            {
                ["Authorization"] = $"bearer {accessToken}"

            };

            // ساخت کد پرداخت به منظور هدایت به درگاه بانکی
            var res = await RequestHelper.CallApi<PayPing_PaymentResult>(_PAYPING_API["PAYMENT_URL"], model, headers);

            return new toPayResponse()
            {
                Amount = dto.BillingAmount,
                payCode = res.Data.Code,
                PayService = EnumHelper.GetEnumDescription<PayServiceType>(dto.PayService),
                PayUrl = _PAYPING_API["GOTOIPG_URL"] + res.Data.Code,
            };
        }

        public async Task<bool> VerifyPayment(toVerifyDto dto)
        {
            var verifyBody = new PayPing_RequestVerify
            {
                Amount = ((int)dto.BillAmount.Value), // مبلغ به توامن می باشد
                RefId = dto.refId,

            };

            string accessToken = _PAYPING_API["Key"];
            Dictionary<string, string> headers = new()
            {
                ["Authorization"] = $"bearer {accessToken}"

            };


            // اگر وریفای با موفقیت انجام پذیرد، تنها وضعیت 200 را برگشت می دهد و حاوی هیچ دیتایی نیست
            // اما اگر به هر دلیلی ادامه فرایند وریفای مقدور نباشد، 400 برگشت می دهد به همراه یک متن خطا
            var result = await RequestHelper.CallApi<string>(_PAYPING_API["VERIFY_URL"], verifyBody, headers);

            if (result.Content == string.Empty)
                return true;

            return false;


           
        }
    }
}
