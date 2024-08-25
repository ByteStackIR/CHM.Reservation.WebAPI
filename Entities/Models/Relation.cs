using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Relation : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        public RelationType Type { get; set; }

        [ForeignKey(nameof(Parent))]
        public Guid? ParentId { get; set; }


        public Relation Parent { get; set; }


        [InverseProperty(nameof(Parent))]
        public ICollection<Relation> Children { get; set; }


        public ICollection<CouponShare> CouponShare { get; set;} = new List<CouponShare>();
        public ICollection<Relatives> Relatives { get; set; } = new List<Relatives>();
    }
}
