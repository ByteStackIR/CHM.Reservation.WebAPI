using Entities.DataTransferObjects.Models;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IRelationsService
    {
        Task<RelationDto> GetByType(RelationType type);
        Task<bool> NeedConfirmation(Guid Id);
        Task<bool> CheckMaximumLimit(Guid RelationId, Guid UserId);
        Task<bool> CanBeDeleted(Guid RelationId);
    }
}
