using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.PayPing
{
    public class ZarinPal_RequestPayment
    {

        public string merchant_id { get; set; }
        public int amount { get; set; }
        /// <summary>
        /// clientrefId باید به انتهای اضافه شده
        /// استاندارد برنامه اینه که آیدی تراکنش باشه
        /// </summary>
        public string callback_url { get; set; }
        public string description { get; set; }
        public Metadata metadata { get; set; }

    }

    public class Metadata
    {
        public string mobile { get; set; }
        public string email { get; set; }
    }
}
