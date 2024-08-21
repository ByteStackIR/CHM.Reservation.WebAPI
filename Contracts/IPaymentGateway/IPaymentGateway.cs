using Entities.DataTransferObjects.PayingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IPaymentGateway
{
    public interface IPaymentGateway
    {

         Task<toPayResponse> InitilizePayment(BillingDto dto);
         Task<bool> VerifyPayment(toVerifyDto dto);
    }
}
