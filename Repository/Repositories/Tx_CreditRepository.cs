using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class Tx_CreditRepository : RepositoryBase<Tx_Credit>, ITx_CreditRepository { public Tx_CreditRepository(DBContextProvider dBContextProvider) : base(dBContextProvider) { }

        public async Task<decimal> GetUsedByUser(Expression<Func<Tx_Credit, bool>> expression)
        {
            return
             await _dbSet.Where(
                  expression
               )
               .Select(x => x.Amount)
               .SumAsync();
        }

    }

}
