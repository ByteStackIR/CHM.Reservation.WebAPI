using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.ZarinPal
{
    public class ZarinPal_RequestVerify
    {

        public string merchant_id { get; set; }
        public int amount { get; set; }
        public string authority { get; set; }

    }
}
