using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum PayStatusType : sbyte
    {
        [Description("قبلا تایید شده ")]
        AlreadyVerified = -1,
        [Description("در حال انجام")]
        InProgress = 0,
        [Description("تایید شده")]
        Verified = 1,
        [Description("باطل شده")]
        Refuted = 2

    }
}
