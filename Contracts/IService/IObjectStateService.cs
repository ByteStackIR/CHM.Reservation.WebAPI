using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IObjectStateService
    {
         Task<List<ObjectStateDto>> GetByCategoryId(Guid CategoryId);
         Task<ObjectStateDto> GetStateByCode(Guid CategoryId,int Code);
         Task<ObjectStateDto> GetStateById(Guid Id);
         Task<ObjectStateDto> GetNextStateByState(ObjectStateDto dto);
         Task<ObjectStateDto> GetPreviousStateByState(ObjectStateDto dto);

        Task<ObjectStateDto> GetStartStateByCategoryId(Guid CategoryId);
        
        
    }
}
