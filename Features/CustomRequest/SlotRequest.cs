using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.CustomRequest
{
    public class SlotRequest : Features.RequestFeatures.RequestFeatures
    {
        public Guid EntityId { get; set; }
    }
}
