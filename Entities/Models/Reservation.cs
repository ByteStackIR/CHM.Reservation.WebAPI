using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Reservation : ModelBase
    {
        public Guid SlotId { get; set; }
        public string UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }

        public Slots Slots { get; set; } = new Slots();
        public User User { get; set; } = new User();

        public ICollection<SelectedRelatives> SelectedRelatives { get; set; } = new List<SelectedRelatives>();
        public ICollection<Tx_Coupon> TxCoupons { get; set; } = new List<Tx_Coupon>();
        public ICollection<Tx_User> TxUsers { get; set; } = new List<Tx_User>();
    }
}
