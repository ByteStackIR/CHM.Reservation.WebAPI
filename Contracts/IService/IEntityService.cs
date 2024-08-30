using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IEntityService
    {
        Task<EntityDto> AddEntityAsync(EntityDto dto);
        Task<EntityDto> GetEntityByIdAsync(Guid entityId);
    }
}
