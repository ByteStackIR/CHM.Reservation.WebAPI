using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Internal
{
    public class Internal_TransactionDto {

        public Guid Id { get; set; }
        public Guid? ReservationId { get; set; }
        public Guid PeriodId { get; set; }

        public string UserId { get; set; }

        public string CreatorUserId { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
