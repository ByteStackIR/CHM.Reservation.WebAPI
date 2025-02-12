using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.Constant;
using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Entities.QueryExtensions;
using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Repositories.Repositories
{
    public class EntityRepository : RepositoryBase<Entity> , IEntityRepository, IScopeMarker
    {
        public EntityRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<PaginationDto<Entity>> GetPagedCurrentEntities(RequestFeatures request) {
           
            var query =  _dbSet.Where(e => e.StartDate <= DateTime.Now && e.EndDate >= DateTime.Now)
                    .Include(e => e.Category)
                    .Include(e => e.ParameterValues);
            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();

            return new()
            {
                Data = data,
                TotalCount = count
            };

        }

        public async Task<IEnumerable<Entity>> GetCurrentEntities()
        {

            var query = _dbSet.Where(e => e.StartDate <= DateTime.Now && e.EndDate >= DateTime.Now)
                    .Include(e => e.Category)
                    .Include(e => e.ParameterValues);
   
            var data = await query.ToListAsync();

            return data;

        }

        public async Task<Entity> GetSpecifiedEntityAsync(Guid Id)
        {
            //TODO: Add State Condition
            //NOTE: NOTE
            return await _dbSet.Where(e => e.Id == Id)
                 .Include(x => x.City)
                 .Include(e => e.Category)
                 .Include(e => e.ParameterValues.OrderBy(x => x.DisplayOrder))
                 .ThenInclude(x => x.Parameter)
                 .Include(e => e.Slots)
                 .ThenInclude(x =>
                     x.Reservations.Where(reservation =>
                         (
                             reservation.IsFinalized
                             && (
                                 reservation.ObjectStateId
                                     != Guid.Parse(CancelStateConstant.HotelCancelState)
                                 && reservation.ObjectStateId
                                     != Guid.Parse(CancelStateConstant.TourCancelState)
                             )
                         )
                         || (
                             reservation.IsFinalized == false
                             && reservation.ExpirationDate >= DateTime.Now
                         )
                     )
                 )
                 .ThenInclude(x =>
                     x.SelectedRelatives
                 ).FirstOrDefaultAsync();
        }









        public async Task<PaginationDto<Entity>> GetPagedEntities_Admin(RequestFeatures request)
        {
            var query = _dbSet
                .Include(x => x.Category)
                .OrderByDescending(x => x.StartDate);

            var count = await query.CountAsync();

            var data = await query.GetPage(request).ToListAsync();

            return new()
            {
                Data = data,
                TotalCount = count
            };
        }

        public async Task<Entity> GetEntityById_Admin(Guid Id)
        {
            return await _dbSet.Where(x => x.Id == Id)
                    .Include(x => x.Slots)
                    .Include(x => x.ParameterValues.OrderBy(x => x.DisplayOrder))
                    .Include(x => x.EntityManagers)
                    .FirstOrDefaultAsync();
        }


        public async Task<Entity> GetEntityInformationByIdAsync(Guid Id)
        {
            return await _dbSet.Where(x => x.Id == Id)
                    .Include(x => x.ParameterValues.OrderBy(x => x.DisplayOrder))
                    .ThenInclude(x => x.Parameter)
                    .Include(x => x.Slots)
                    .FirstOrDefaultAsync();
        }
    }
}
