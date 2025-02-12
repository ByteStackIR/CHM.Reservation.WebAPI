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
    public class UserCompanyRepository : RepositoryBase<UserCompany> , IUserCompanyRepository, IScopeMarker
    {
        public UserCompanyRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<PaginationDto<UserCompany>> GetNotCheckedRelativesAsAdmin(RequestFeatures request)
        {
            var query =  _dbSet.Where(x => x.IsActive == true)
            .Include(y => y.User.Relatives.Where(r => r.IsChecked == false && r.IsDeleted == false))
            .Where(x => x.User.Relatives.Any(r => r.IsChecked == false && r.IsDeleted == false))
            .Include(x => x.Company)
            .OrderByDescending(x => x.CreatedDate);

            return new()
            {
                Data = query.GetPage(request).ToList(),
                TotalCount = query.Count()
            };
        }

        public async  Task<PaginationDto<UserCompany>> GetNotCheckedRelativesAsCompany(RequestFeatures request, Guid CompanyId)
        {
           var query = _dbSet.Where(
                x => x.IsActive && x.CompanyId == CompanyId
                
            )
            .Include(y => y.User)
            .ThenInclude(z => z.Relatives.Where(x => !x.IsChecked && !x.IsDeleted))
            .Include(x => x.Company)
            .OrderByDescending(x => x.CreatedDate);

            return new()
            {
                Data = query.GetPage(request).ToList(),
                TotalCount = query.Count()
            };
        }

        public async Task<UserCompany> GetWithCompany(Expression<Func<UserCompany, bool>> expression)
        {
            return await _dbSet.Where(expression).Include(x => x.Company).FirstOrDefaultAsync();
        }

        public async Task<UserCompany> PickNewest(Expression<Func<UserCompany, bool>> expression)
        {
            return await _dbSet.Where(expression).OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();
        }
    }
}
