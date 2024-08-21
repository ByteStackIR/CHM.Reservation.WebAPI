using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayingDto
{
    /// <summary>
    /// جواب درخواست برای پرداخت صورتحساب
    /// </summary>
    public class toPayResponse
    {
        /// <summary>
        /// مقدار کل پرداخت
        /// </summary>
        public Decimal Amount {  get; set; }
        public string? payCode { get; set; }
        public string PayUrl { get; set; }

        public string PayService { get; set; }

    }
}
