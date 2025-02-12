using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IPeriodRepository : IRepositoryBase<Period>
    {

        Task<PaginationDto<Period>> GetAllPeriods(RequestFeatures request);
        Task<Period> PickNewest(Expression<Func<Period, bool>> expression);
    }
}
