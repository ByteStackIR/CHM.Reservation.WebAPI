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
        public bool IsDeleted { get; set; }

        public ICollection<CouponShare> CouponShare { get; set; } 
        public ICollection<Tx_Coupon> TxCoupons { get; set; } 
        public ICollection<Tx_User> TxUsers { get; set; }
    }
}
