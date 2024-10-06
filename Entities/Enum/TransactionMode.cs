using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum TransactionMode : sbyte
    {
        /// <summary>
        /// بر عهده سرانه
        /// </summary>
        CouponMode = 0,
        /// <summary>
        /// از طریق اعتبار
        /// </summary>
        CreditMode = 1,
        /// <summary>
        /// هر دو باهم
        /// </summary>
        CouponAndCreditMode = 2


    }
}
