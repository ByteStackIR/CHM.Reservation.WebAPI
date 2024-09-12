using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Internal
{
    public class Internal_ShareDto
    {
        public RelativeDto Relative { get; set; }
        public Guid CouponShareId { get; set; }

        public Decimal CompanyShare {  get; set; }
        public Decimal UserShare {  get; set; }

    }

  
}
