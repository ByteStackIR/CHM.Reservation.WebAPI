using Contracts.IDapperRepository;
using Contracts.IRepository;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class TransactionRepository : RepositoryBase<Transactions>, ITransactionRepository
    {
        public TransactionRepository(DBContextProvider dBContextProvider) : base(dBContextProvider) { }


     


    }
}
