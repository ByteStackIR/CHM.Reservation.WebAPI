using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    
    public class Reservation : ModelBase
    {
        [Required]
        [ForeignKey(nameof(Slot))]
        public Guid SlotId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }

        public Slot Slot { get; set; } = new Slot();
        public User User { get; set; } = new User();

        [Required]
        [ForeignKey(nameof(ObjectState))]
        public Guid ObjectStateId { get; set; }

        public ObjectStates ObjectState { get; set; }
        public ICollection<SelectedRelatives> SelectedRelatives { get; set; }
        public ICollection<Tx_Coupon> TxCoupons { get; set; } 
        public ICollection<Tx_User> TxUsers { get; set; }
    }
}
