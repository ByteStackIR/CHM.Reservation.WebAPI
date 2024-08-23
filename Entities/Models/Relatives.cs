using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Relatives
    {
        public Guid PersonId { get; set; }
        public Guid RelationId { get; set; }
        public bool IsConfirmed { get; set; }

        public Persons Person { get; set; } = new Persons();
        public Relation Relation { get; set; } = new Relation();

        public ICollection<SelectedRelatives> SelectedRelatives { get; set; } = new List<SelectedRelatives>();
    }
}
