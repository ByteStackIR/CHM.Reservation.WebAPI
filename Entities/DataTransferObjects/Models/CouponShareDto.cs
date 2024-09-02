using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class CouponShareDto
    {
        public Guid? Id { get; set; }

        public Guid PeriodId { get; set; }
      
        public Guid RelationId { get; set; }
        public Decimal Entitlement { get; set; }


        public DateTime CreatedDate { get; set; }
    }
}
