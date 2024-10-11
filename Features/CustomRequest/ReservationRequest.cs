using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.CustomRequest
{
    public class ReservationRequest_User : Features.RequestFeatures.RequestFeatures
    {
        //public string UserId { get; set; }
    }

    public class ReservationRequest_Hotel : Features.RequestFeatures.RequestFeatures
    {
        public Guid EntityId { get; set; }
    }

    public class ReservationRequest : Features.RequestFeatures.RequestFeatures 
    {
        public Guid EntityId { get; set; }
    }

    public class ReservationRequest_Executive : Features.RequestFeatures.RequestFeatures
    {
        //public string UserId { get; set; }
    }
}
