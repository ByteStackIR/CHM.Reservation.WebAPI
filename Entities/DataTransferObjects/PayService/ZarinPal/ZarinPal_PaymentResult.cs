using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.ZarinPal
{
  
        public class ZarinPal_PaymentResult
        {
            public DataPayment data { get; set; }
            public List<string> errors { get; set; }
        }

        public class DataPayment
    {
            public int code { get; set; }
            public string message { get; set; }
        /// <summary>
        /// این همان refId
        /// یا کد درگاه پرداخت هست
        /// </summary>
            public string authority { get; set; }
            public string fee_type { get; set; }
            public int fee { get; set; }
        }
    
}
