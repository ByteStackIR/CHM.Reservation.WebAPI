using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserCompany : ModelBase
    {
        public string UserId { get; set; } 
        public Guid CompanyId { get; set; }
        public bool IsActive { get; set; }
        
        public User User { get; set; } = new User();
        public Company Company { get; set; } = new Company();
    }
}
