using Entities.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Relatives : ModelBase
    {
        [Required]
        [ForeignKey(nameof(Relation))]
        public Guid RelationId { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]

        public string IdentityCode { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public string FatherName { get; set; } 

        public GenderType Gender { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public bool IsChecked { get; set; }
        public bool IsConfirmed { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public User User { get; set; }
        public Relation Relation { get; set; } 
        public bool IsDeleted { get; set; }
        public ICollection<SelectedRelatives> SelectedRelatives { get; set; } 
    }
}
