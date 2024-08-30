using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Entity : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        [ForeignKey(nameof(Period))]
        public Guid PeriodId { get; set; }
        public Decimal PerPerson { get; set; }
        /// <summary>
        /// Maximum Share of company = means that can be less than
        /// </summary>
        public Decimal CompanyShare { get; set; }
        /// <summary>
        /// minimum Share of person = means that can be greater than
        /// </summary>
        public Decimal PersonShare { get; set; }
        public bool Cancelable { get; set; }
        public Int16 MaxReserveTimes { get; set; }
        public Int16 MinAge { get; set; }
        public Int16 DaysToCancel { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public User User { get; set; }

        public Category Category { get; set; } = new Category();
        public Period Period { get; set; } = new Period();
        public ICollection<Slot> Slots { get; set; } = new List<Slot>();
        public ICollection<ParameterValues> ParameterValues { get; set; } = new List<ParameterValues>();
    }
}
