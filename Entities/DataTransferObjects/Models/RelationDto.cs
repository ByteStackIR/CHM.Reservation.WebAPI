using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
public    class RelationDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public RelationType Type { get; set; }

        public Guid? ParentId { get; set; }

        public int? Maximum { get; set; }
    
        public DateTime CreatedDate { get; set; }
    }
}
