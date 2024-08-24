using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public sealed class ObjectStates : ModelBase
    {
        public int Code { get; set; }
        public string Title {  get; set; }
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        public bool Cancellable { get; set; }
        public bool ToForward { get; set; }
        public bool ToBackward { get; set; }

        [ForeignKey(nameof(Role))]
        [Required]
        public string RoleId { get; set; }
        public IdentityRole Role { get; set; }
        public Category Category { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<ReservationStates> ReservationStates { get; set; }


    }
}
