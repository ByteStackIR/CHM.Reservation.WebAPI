using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IRepository;
using Contracts.IService;
using LoggerService;
using Microsoft.AspNetCore.Http;

namespace Services.Services
{
    public class ReservationStateService : ServiceBase, IReservationStateService
    {
        public ReservationStateService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }
    }
}
