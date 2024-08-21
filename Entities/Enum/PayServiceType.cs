using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum PayServiceType : sbyte
    {
        [Description("رایگان")]
        NoService = -1,
        [Description("پی پینگ")]
        PayPing = 0,
        [Description("زرین پال ")]
        ZarinPall = 1,
        [Description("زیبال")]
        Zibal = 2,
    }
}
