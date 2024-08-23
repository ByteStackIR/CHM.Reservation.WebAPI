using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Relatives : ModelBase
    {
        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        [ForeignKey(nameof(Relation))]
        public Guid RelationId { get; set; }
        public bool IsConfirmed { get; set; }

        public Persons Person { get; set; } = new Persons();
        public Relation Relation { get; set; } = new Relation();

        public ICollection<SelectedRelatives> SelectedRelatives { get; set; } = new List<SelectedRelatives>();
    }
}
