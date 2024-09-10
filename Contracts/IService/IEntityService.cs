using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IEntityService
    {
        Task<PagedData<List<EntityDto>>> GetPagedEntities(AdminEntitiesTableRequest request);
        Task<PagedData<List<EntityDto>>> GetPagedCurrentEntitiesAsync(PublicEntitiesTableRequest request);
        Task<EntityDto> AddEntityAsync(EntityDto dto);
        Task<EntityDto> GetEntityByIdAsync(Guid entityId);
        Task DeleteEntityByIdAsync(Guid entityId);
        Task<EntityDto> UpdateEntityAsync(EntityDto entityDto);
        Task<EntityDto> GetEntityInformationByIdAsync(Guid entityId);


        //===========PUBLIC AREA
        Task<EntityDataDto> GetSpecifiedEntityAsync(Guid EntityId);
    }
}
