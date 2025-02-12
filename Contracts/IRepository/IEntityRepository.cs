using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IEntityRepository : IRepositoryBase<Entity>
    {
        Task<PaginationDto<Entity>> GetPagedCurrentEntities(RequestFeatures request);

        Task<IEnumerable<Entity>> GetCurrentEntities();

        Task<Entity> GetSpecifiedEntityAsync(Guid Id);

        Task<PaginationDto<Entity>> GetPagedEntities_Admin(RequestFeatures request);
        Task<Entity> GetEntityById_Admin(Guid Id);
        Task<Entity> GetEntityInformationByIdAsync(Guid Id);


    }
}
