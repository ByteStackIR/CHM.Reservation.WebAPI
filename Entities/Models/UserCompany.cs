using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        [Required]
        public string PersonnelCode { get; set; }
        
        public User User { get; set; } 
        public Company Company { get; set; } 
    }
}
