using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    public abstract class Tx_Base : ModelBase
    {

        [ForeignKey(nameof(Reservation))]
        public Guid? ReservationId { get; set; }

        [ForeignKey(nameof(Period))]
        [Required]
        public Guid PeriodId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        [Required]
        [ForeignKey(nameof(CreatorUser))]
        public string CreatorUserId { get; set; }

        public Decimal Amount { get; set; }

        public string Description { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Reservation Reservation { get; set; }
        public Period Period { get; set; }
        public User User { get; set; }
        public User CreatorUser { get; set; }
    }
}
