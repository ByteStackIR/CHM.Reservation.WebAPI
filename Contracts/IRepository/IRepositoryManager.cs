using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IRepositoryManager
    {

        ITransactionRepository ITransactionRepository { get; }

        void Save();
    }
}
