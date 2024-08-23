using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Period : ModelBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Decimal Stipend { get; set; }

        public ICollection<CouponShare> CouponShare { get; set; } = new List<CouponShare>();
        public ICollection<Tx_Coupon> TxCoupons { get; set; } = new List<Tx_Coupon>();
        public ICollection<Tx_User> TxUsers { get; set; } = new List<Tx_User>();
    }
}
