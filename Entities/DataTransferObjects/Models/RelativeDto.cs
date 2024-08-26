using Entities.Enum;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class RelativeDto
    {
        public Guid Id { get; set; }
        public Guid RelationId { get; set; }
        public string IdentityCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; } 
        public GenderType Gender { get; set; }

        [NotMapped]
        public string GenderTitle { get; set; }
        public string UserId { get; set; }

        public bool IsChecked { get; set; }
        public bool IsConfirmed { get; set; }

    
    
    
    }
}
