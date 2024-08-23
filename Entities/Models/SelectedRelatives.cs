using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class SelectedRelatives : ModelBase
    {
        [ForeignKey(nameof(Reservation))]
        public Guid ReservationId { get; set; }
        [ForeignKey(nameof(Relative))]
        public Guid RelativeId { get; set; }

        public Reservation Reservation { get; set; } = new Reservation();
        public Relatives Relative { get; set; } = new Relatives(); 
    }
}
