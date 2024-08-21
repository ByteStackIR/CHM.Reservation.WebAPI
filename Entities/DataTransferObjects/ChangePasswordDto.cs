using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ChangePasswordDto
    {
        public Guid? UserId { get; set; } 
        public string Password { get; set; }
        public string CurrentPassword { get; set; }
    }
}
