using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class OTPResultDto
    {
        public string PhoneNumber { get; set; }
        public string Code { get; set; }

        public bool IsError { get; set; }
        public bool IsSuccesed { get; set; }
        public List<string> Errors { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
