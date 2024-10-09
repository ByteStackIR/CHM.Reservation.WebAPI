using Entities.DataTransferObjects.Models;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.External
{
    public class External_ReservationDto
    {
        public Guid Id { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }
        public TransactionMode? TransactionMode { get; set; }
        public bool IsFinalized { get; set; } = false;
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ObjectStateTitle { get; set; }

        public EntityDto Entity { get; set; }
        public SlotDto Slot { get; set; }

        public List<External_SelectedRelativeDto> Relatives { get; set; }



    }
}
