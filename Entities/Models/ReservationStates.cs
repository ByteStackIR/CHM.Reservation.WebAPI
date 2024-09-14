using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public sealed class ReservationStates : ModelBase
    {
        [Required]
        [ForeignKey(nameof(Reservation))]
        public Guid ReservationId { get; set; }

        [Required]
        [ForeignKey(nameof(ObjectState))]
        public Guid ObjectStateId { get; set; }
        public bool ToForward { get; set; }

        public bool IsCancelled { get; set; }

        public bool IsDone { get; set; }
        [Required]
        [ForeignKey(nameof(CreatorUser))]
        public string CreatorUserId { get; set; }

        [ForeignKey(nameof(ActorUser))]
        public string? ActorUserId { get; set; }

        public User CreatorUser { get; set; }
        public User? ActorUser { get; set; }
    

        public ObjectStates ObjectState { get; set; }
        public Reservation Reservation { get; set; }

    }
}
