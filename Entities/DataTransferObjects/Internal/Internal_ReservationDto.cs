using Entities.DataTransferObjects.Models;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
        
        public Guid CategoryId { get; set; }
        public Guid EntityId { get; set; }
        public DateTime CreatedDate { get; set; }

        public bool IsFinalized { get; set; } = false;
        public DateTime ExpirationDate { get; set; }

        public TransactionMode TransactionMode { get; set; }
        public List<Internal_ShareDto> Shares {  get; set; } 
    }
}
