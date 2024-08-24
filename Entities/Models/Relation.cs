using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Relation : ModelBase
    {
        public string Title { get; set; } = string.Empty;

        public RelationType Type { get; set; }
        public ICollection<CouponShare> CouponShare { get; set;} = new List<CouponShare>();
        public ICollection<Relatives> Relatives { get; set; } = new List<Relatives>();
    }
}
