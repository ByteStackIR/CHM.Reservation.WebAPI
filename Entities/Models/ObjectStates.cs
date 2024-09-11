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


        public int? NextNode { get; set; }
        public int? PreviousNode { get; set; }

        public int? CancelNode { get; set; }

        public string Title {  get; set; }
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }


        /// <summary>
        /// کاربر ایجاد کننده میتواند کنسل کند
        /// </summary>
        public bool Cancellable { get; set; }
        /// <summary>
        /// اجازه حرکت رو به جلو
        /// </summary>
        public bool ToForward { get; set; }
        /// <summary>
        /// اجازه حرکت رو به عقب
        /// </summary>
        public bool ToBackward { get; set; }

        [ForeignKey(nameof(Role))]
        [Required]
        public string RoleId { get; set; }
        public IdentityRole Role { get; set; }
        public Category Category { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<ReservationStates> ReservationStates { get; set; }

        /// <summary>
        /// نقطه پایانی هست یا خیر
        /// </summary>
        public bool IsFinalNode { get; set; }
    }
}
