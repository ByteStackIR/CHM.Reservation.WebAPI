using Contracts.IMarker;
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
    public class CouponShareRepository : RepositoryBase<CouponShare> , ICouponShareRepository, IScopeMarker
    {
        public CouponShareRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<IEnumerable<CouponShare>> GetRelationSharesInPeriod(List<Guid> RelationIds, Guid PeriodId)
        {
            return await _dbSet.Where(x => RelationIds.Contains(x.RelationId) && x.PeriodId == PeriodId).Include(x=>x.Relation).ToListAsync();
        }
    }
}
