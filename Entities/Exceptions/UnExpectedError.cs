using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UnExpectedError : BadRequestException
    {
        public UnExpectedError(string message = "خطای ناگهانی") : base(message) { }
    }
}
