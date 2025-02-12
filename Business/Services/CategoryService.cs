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
    public class CategoryService : ServiceBase, ICategoryService, IScopeMarker
    {
        public CategoryService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }


        public async Task<List<CategoryDto>> GetAllCategories()
    {
            var res = await _repositoryManager
                .Category.FindAll(x=>true)
                ;

            return _mapper.Map<List<CategoryDto>>(res);
        }
    }
}
