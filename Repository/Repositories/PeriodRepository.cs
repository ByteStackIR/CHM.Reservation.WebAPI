using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Entities.QueryExtensions;
using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class PeriodRepository : RepositoryBase<Period> , IPeriodRepository, IScopeMarker
    {
        public PeriodRepository(DBContextProvider context) : base(context)
        {
        
        }

        public async Task<PaginationDto<Period>> GetAllPeriods(RequestFeatures request)
        {
            var query = _dbSet.OrderByDescending(x=>x.StartDate);
            int count = query.Count();

            var data = await query.GetPage(request).ToListAsync();


            return new()
            {
                Data = data,
                TotalCount = count
            };

        }

        public async Task<Period> PickNewest(Expression<Func<Period, bool>> expression)
        {
           return await _dbSet.Where(expression).OrderByDescending(x=>x.CreatedDate).FirstOrDefaultAsync();
        }
    }
}
