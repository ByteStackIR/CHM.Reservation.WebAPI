using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class SlotDto
    {
        public Guid? Id  { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid EntityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Capacity { get; set; }
        public int? Occupancy { get; set; } = null;
    }
}
