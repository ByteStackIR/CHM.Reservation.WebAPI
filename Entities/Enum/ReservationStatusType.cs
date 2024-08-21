using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public enum ReservationStatusType : byte
    {
        [Description("در جریان")]
        InProgress = 0,
        [Description("تکمیل شده")]
        Completed = 1,
        [Description("کنسل شده")]
        Cancelled = 2
    }
}
