using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum GenderType : sbyte
    {

        [Description("زن  ")]
        Woman = 1,
        [Description("زیبال")]
        Man = 2,
    }
}
