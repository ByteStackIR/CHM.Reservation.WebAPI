using Contracts.IContext;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface ITx_CreditRepository : IRepositoryBase<Tx_Credit> {

        Task<decimal> GetUsedByUser(Expression<Func<Tx_Credit, bool>> expression);
    }



}
