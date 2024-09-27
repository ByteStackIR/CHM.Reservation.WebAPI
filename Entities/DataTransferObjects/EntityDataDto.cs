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
        public int DisplayOrder { get; set; }
        public string Type { get; set; }
    }


    public class EntityDataDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public CategoryDto Category { get; set; }
        public int minAge { get; set; }
        public List<AttributeOfEntity> Attributes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Decimal PerPerson { get; set; }
        public List<SlotDto> Slots { get; set; }
        public string CityTitle { get; set; }
    }
}
