using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface ICouponTransactionService
    {

        Task<Tx_CouponDto> AddTransaction(Internal_TransactionDto dto);


    }
}
