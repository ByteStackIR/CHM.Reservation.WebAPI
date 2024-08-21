using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IPaymentGateway
{
    public interface IPaymentFactory
    {
        IPaymentGateway GetInstanceByType(PayServiceType PayService);
    }
}
