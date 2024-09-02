using AutoMapper;
using Contracts.IRepository;
using Entities.DataTransferObjects.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IContext
{
    public interface ISystemContext
    {
        public ClaimsPrincipal CurrentUser { get; set; }

        public CompanyDto UserCompany { get; set; }

        public PeriodDto Period { get; set; }

        Task InitializeSystemContext(IRepositoryManager repositoryManager, IHttpContextAccessor httpContextAccessor, IMapper mapper);
    }
}
