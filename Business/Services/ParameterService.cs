namespace Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Contracts.IService;
    using Entities.DataTransferObjects;
    using Entities.DataTransferObjects.Models;
    using Entities.Models;
    using Entities.QueryExtensions;
    using Features.CustomRequest;
    using Features.RequestFeatures;
    using LoggerService;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="UsersService" />
    /// </summary>
    public class ParameterService : ServiceBase, IParameterService, IScopeMarker
    {
        public ParameterService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<List<ParameterDto>> ParametersByCategoryId(Guid CategoryId)
        {
            var res = await _repositoryManager
                .Parameter.FindAll(x => x.CategoryId == CategoryId);

            return _mapper.Map<List<ParameterDto>>(res);
        }
    }
}
