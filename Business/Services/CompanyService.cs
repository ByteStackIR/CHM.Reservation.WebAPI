using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CompanyService : ServiceBase, ICompanyService, IScopeMarker
    {
        public CompanyService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext)
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        { }

        public async Task<PagedData<List<CompanyDto>>> GetPagedAllCompanies(CompanyRequest request)
        {
            var data =await _repositoryManager.Company.FindAll(x=>true);
     
            var dataDto = _mapper.Map<List<CompanyDto>>(data);
            return new(new(data.Count, request.PageNumber, request.PageSize), dataDto);
        }

    }
}
