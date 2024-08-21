using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.Zibal
{
    public class Zibal_PaymentRequest
    {
        public string merchant {  get; set; }
        public long amount { get; set; }
        public string callbackUrl { get; set; }
        public string description { get; set; }
        public string mobile { get; set; }

    }
}
