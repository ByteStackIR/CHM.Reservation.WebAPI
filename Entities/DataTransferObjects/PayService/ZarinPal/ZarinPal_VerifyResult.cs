using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.ZarinPal
{
   
    public class ZarinPal_VerifyResult
    {
        public DataVerify data { get; set; }
        public ZarinPall_errors errors { get; set; }
    }

    public class DataVerify
    {
        public int code { get; set; }
        public string message { get; set; }
        public string card_hash { get; set; }
        public string card_pan { get; set; }
        public int ref_id { get; set; }
        public string fee_type { get; set; }
        public int fee { get; set; }
    }

    public class ZarinPall_errors
    {
        public string message { get; set; }
        public string code { get; set; }

    }
}
