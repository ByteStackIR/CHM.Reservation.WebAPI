using Entities.DataTransferObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService.IStateHandler
{
    public interface IStateHandlerService
    {
        Task<ObjectStateDto> GenerateFirstStep(Guid CategoryId);
    }
}
