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
    public class Tx_CouponRepository : RepositoryBase<Tx_Coupon> , ITx_CouponRepository, IScopeMarker
    {
        public Tx_CouponRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<decimal> GetUsedByUser(Expression<Func<Tx_Coupon, bool>> expression)
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
