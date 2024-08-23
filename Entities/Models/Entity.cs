using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Entity : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid PeriodId { get; set; }
        public Decimal PerPerson { get; set; }
        public Decimal CompanyShare { get; set; }
        public Decimal PersonShare { get; set; }
        public bool Cancelable { get; set; }
        public Int16 MaxReserveTimes { get; set; }
        public Int16 MinAge { get; set; }
        public Int16 DaysToCancel { get; set; }

        public Category Category { get; set; } = new Category();
        public ICollection<Slots> Slots { get; set; } = new List<Slots>();
    }
}
