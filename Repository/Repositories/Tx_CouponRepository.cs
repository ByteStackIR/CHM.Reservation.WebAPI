using Contracts.IRepository;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class Tx_CouponRepository : RepositoryBase<Tx_Coupon> , ITx_CouponRepository
    {
        public Tx_CouponRepository(DBContextProvider context) : base(context)
        {

        }
    }
}
