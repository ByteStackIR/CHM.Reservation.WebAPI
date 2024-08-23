using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class SelectedRelatives : ModelBase
    {
        public Guid ReservationId { get; set; }
        public Guid RelativeId { get; set; }

        public Reservation Reservation { get; set; } = new Reservation();
        public Relatives Relative { get; set; } = new Relatives(); 
    }
}
