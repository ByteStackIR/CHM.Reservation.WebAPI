using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Services
{
    public class DefinitionsService : ServiceBase, IDefinitionsService, IScopeMarker
    {
        public DefinitionsService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext)
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        { }

        public async Task<List<DefinitionsDto>> GetDefinitionsAsync(Guid parentId)
        {
            var cities = _repositoryManager.IDefinitionsRepository.FindByCondition(d => d.ParentId == parentId,false).ToList();
            var citiesDto = _mapper.Map<List<DefinitionsDto>>(cities);
            return citiesDto;
        }
    }
}
