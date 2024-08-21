using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayingDto
{   
    /// <summary>
    /// برای جابه جایی صورتحساب بین سرویس های خود برنامه
    /// </summary>
    public class BillingDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? DiscountId { get; set; }
        public Guid UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillingAmount { get; set; }
        public string ReturnUrl { get; set; }
        public Guid TransactionId { get; set; }
        public Guid TempReservationId { get; set; }

        public PayServiceType PayService {  get; set; }  
    }





}
