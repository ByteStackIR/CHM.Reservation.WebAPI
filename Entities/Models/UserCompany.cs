using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserCompany : ModelBase
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [Required]
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public bool IsActive { get; set; }
        
        public User User { get; set; } = new User();
        public Company Company { get; set; } = new Company();
    }
}
