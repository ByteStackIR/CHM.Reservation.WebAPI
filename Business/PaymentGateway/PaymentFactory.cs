using Contracts.IPaymentGateway;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Services.PaymentGateway.PaymentFactory;

namespace Services.PaymentGateway
{
    public class PaymentFactory : IPaymentFactory
    {

        private Dictionary<PayServiceType, IPaymentGateway> _paymentGatway;

        public PaymentFactory(PayPingPayment payPingPayment, ZarinPalPayment ZarinPalPayment, ZibalPayment ZibalPayment)
        {
            _paymentGatway = new()
            {
                    { PayServiceType.PayPing, payPingPayment },
                    { PayServiceType.ZarinPall, ZarinPalPayment },
                      { PayServiceType.Zibal, ZibalPayment }
            };
        }


        public IPaymentGateway GetInstanceByType(PayServiceType PayService)
        {
            return _paymentGatway[PayService];
        }
    }
}
