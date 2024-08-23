using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Tx_Base : ModelBase
    {
        [ForeignKey(nameof(Reservation))]

        public Guid? ReservationId { get; set; }
        [ForeignKey(nameof(Period))]
        public Guid PeriodId { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public Decimal Amount { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Reservation? Reservation { get; set; } = new Reservation();
        public Period Period { get; set; } = new Period();
        public User User { get; set; } = new User();
    }
}
