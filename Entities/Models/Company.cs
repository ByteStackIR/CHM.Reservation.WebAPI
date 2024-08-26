using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        public bool IsDeleted {  get; set; } 
        public ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
    }
}
