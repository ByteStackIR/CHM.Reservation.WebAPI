using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Persons : ModelBase
    {
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string IdentityCode { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string FamilyName {  get; set; } = string.Empty;
        public GenderType Gender { get; set; }

        public ICollection<Relatives> Relatives { get; set; } = new List<Relatives>();
    }
}
