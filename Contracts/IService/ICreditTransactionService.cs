using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface ICreditTransactionService
    {

        Task<Tx_CreditDto> AddTransaction(Internal_TransactionDto dto);
        Task<Tx_CreditDto> AddTransaction(AddToCreditDto dto);

        Task<decimal> GetUserRemainingCredit(Guid UserId);
        Task<Decimal> GetRemainingCredit();
    }
}
