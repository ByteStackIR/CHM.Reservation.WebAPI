using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class EntityDto
    {
        public Guid? Id { get; set; } = null;
        public Guid CategoryId { get; set; }
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

        public List<ParameterValuesDto> ParameterValues { get; set; } = new List<ParameterValuesDto>();
    }
}
