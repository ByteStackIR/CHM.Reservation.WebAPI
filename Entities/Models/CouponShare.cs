using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CouponShare : ModelBase
    {
        [ForeignKey(nameof(Period))]
        public Guid PeriodId { get; set; }
        [ForeignKey(nameof(Relation))]
        public Guid RelationId { get; set; }

        [Column(TypeName ="decimal(4,2)")]
        public Decimal Entitlement { get; set; }
        
        public Period Period { get; set; } = new Period();
        public Relation Relation { get; set; } = new Relation();
    }
}
