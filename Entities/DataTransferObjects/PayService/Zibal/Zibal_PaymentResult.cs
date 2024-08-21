using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.Zibal
{
    public class Zibal_PaymentResult
    {

        public long trackId { get; set; }
        public int result { get; set; }
        public string payLink { get; set; }
        public string message { get; set; }


    }
}
