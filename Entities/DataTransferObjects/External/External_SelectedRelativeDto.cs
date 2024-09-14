using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.External
{
    public class External_SelectedRelativeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string RelationTitle { get; set; }

        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }

    }
}
