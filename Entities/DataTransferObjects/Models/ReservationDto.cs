using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;

namespace Entities.DataTransferObjects.Models
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public string UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }
        public Guid ObjectStateId { get; set; }
        public TransactionMode? TransactionMode { get; set; }
        public bool IsFinalized { get; set; } = false;
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
