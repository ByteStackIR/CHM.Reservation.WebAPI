using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Slot : ModelBase
    {
        [Required]
        [ForeignKey(nameof(Entity))]

        public Guid EntityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Capacity { get; set; }

        public Entity Entity { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
