using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Tx_Base
    {
        public Guid ReservationId { get; set; }
        public Guid PeriodId { get; set; }
        public Guid UserId { get; set; }
        public Decimal Amount { get; set; }

        public Reservation Reservation { get; set; } = new Reservation();
        public Period Period { get; set; } = new Period();
        public User User { get; set; } = new User();
    }
}
