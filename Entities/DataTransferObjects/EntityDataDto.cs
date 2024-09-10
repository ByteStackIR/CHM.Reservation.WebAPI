using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class AttributeOfEntity
    {
        public Guid PrameterId { get; set; }
        public Guid ValueId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }


    public class EntityDataDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public CategoryDto Category { get; set; }

        public List<AttributeOfEntity> Attributes { get; set; }

        public List<SlotDto> Slots { get; set; }
    }
}
