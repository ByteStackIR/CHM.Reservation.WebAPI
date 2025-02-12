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
    public interface IUserCompanyRepository : IRepositoryBase<UserCompany>
    {
        Task<PaginationDto<UserCompany>> GetNotCheckedRelativesAsAdmin(RequestFeatures request);
        Task<PaginationDto<UserCompany>> GetNotCheckedRelativesAsCompany(RequestFeatures request, Guid CompanyId);

        Task<UserCompany> PickNewest(Expression<Func<UserCompany, bool>> expression);
        Task<UserCompany> GetWithCompany(Expression<Func<UserCompany, bool>> expression);
    }
}
