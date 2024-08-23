using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Slots : ModelBase
    {
        public Guid EntityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Capacity { get; set; }

        public Entity Entity { get; set; } = new Entity();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
