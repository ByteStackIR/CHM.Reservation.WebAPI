using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface ITx_CouponRepository : IRepositoryBase<Tx_Coupon>
    {
        Task<decimal> GetUsedByUser(Expression<Func<Tx_Coupon, bool>> expression);
    }
}
