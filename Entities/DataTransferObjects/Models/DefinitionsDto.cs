using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class DefinitionsDto
    {
        public string Title { get; set; } = null!;
        public Guid? ParentId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DefinitionsDto Parent { get; set; }

        public List<DefinitionsDto> Children { get; set; }
        public List<EntityDto> Entities { get; set; }
    }
}
