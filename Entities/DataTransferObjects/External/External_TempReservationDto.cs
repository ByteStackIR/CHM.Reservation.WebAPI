using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.External
{
    public class External_TempReservationDto
    {
       public Guid Id { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public List<External_SelectedRelativeDto> Relatives { get; set; }
    }
}
