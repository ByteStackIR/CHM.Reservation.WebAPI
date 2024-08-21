using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.CustomRequest
{
    public class DiscountTableRequest : Features.RequestFeatures.RequestFeatures
    {
       public bool? isActive { get; set; }
    }
}
