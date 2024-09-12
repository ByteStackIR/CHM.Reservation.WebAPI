using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Internal
{
    public class Internal_ReservationDto
    {
        public Guid? Id { get; set; }
        public Guid SlotId { get; set; }
        public string UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }
        public Guid? ObjectStateId { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Internal_ShareDto> Shares {  get; set; } 
    }
}
