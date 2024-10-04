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
        /// بر عهده کاربر
        /// </summary>
        UserMode = 0,
        /// <summary>
        /// از طریق اعتبار
        /// </summary>
        CreditMode = 1

    }
}
