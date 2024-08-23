using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CouponShare : ModelBase
    {
        public Guid PeriodId { get; set; }
        public Guid RelationId { get; set; }
        public int Entitlement { get; set; }
        
        public Period Period { get; set; } = new Period();
        public Relation Relation { get; set; } = new Relation();
    }
}
