using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IUserTransactionService
    {

        Task<Tx_UserDto> AddTransaction(Internal_TransactionDto dto);

    }
}
