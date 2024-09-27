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
    public class ParameterValues : ModelBase
    {
        [Required]
        [ForeignKey(nameof(Parameter))]
        public Guid ParameterId { get; set; }

        [Required]
        [ForeignKey(nameof(Entity))]
        public Guid EntityId { get; set; }

        public string Value { get; set; } 

        public int DisplayOrder { get; set; }


        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Parameter Parameter { get; set; }

        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Entity Entity { get; set; }

    }
}
