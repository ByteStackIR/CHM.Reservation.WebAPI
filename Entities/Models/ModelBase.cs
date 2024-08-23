using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [PrimaryKey(nameof(Id))]
    public abstract class ModelBase
    {
        
        public Guid Id { get; set; }

        [Column(TypeName = "datetime")]
        [DefaultValue("(getdate())")]
        public DateTime CreatedDate { get; set; }
    }
}
