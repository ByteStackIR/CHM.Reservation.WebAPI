using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SystemContext : ISystemContext,IScopeMarker
    { 

        public ClaimsPrincipal CurrentUser { get; set; }

        public CompanyDto UserCompany { get; set; } = null;

        public async Task InitializeSystemContext(IRepositoryManager repositoryManager,IHttpContextAccessor httpContextAccessor,IMapper mapper)
        {

            CurrentUser = httpContextAccessor.HttpContext.User;

            if (CurrentUser.Identity.IsAuthenticated)
            {
                var userCompany = repositoryManager.UserCompany.FindByCondition(x => x.IsActive && x.UserId == CurrentUser.GetUserId().Value.ToString(), false).Include(x => x.Company).FirstOrDefault();

                UserCompany = mapper.Map<CompanyDto>(userCompany.Company);
            }
            return;
        }

       

    }
}
