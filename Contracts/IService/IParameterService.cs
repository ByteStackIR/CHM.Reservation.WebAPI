using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IParameterService
    {
        
        Task<List<ParameterDto>> ParametersByCategoryId(Guid CategoryId);
    }
}
