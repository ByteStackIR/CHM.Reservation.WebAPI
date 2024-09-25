using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.IdentityExtensions;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Tx_CouponService : ServiceBase, ITx_CouponService, IScopeMarker
    {
        public Tx_CouponService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext)
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<Decimal> GetUsedAmountOfCoupon() 
        {
            var currentPeriodId = _systemContext.Period.Id;
            var currentUserId = _systemContext.CurrentUser.GetUserId().Value.ToString();
            var usedAmount = await _repositoryManager.Tx_Coupon.FindByCondition(tc => tc.PeriodId == currentPeriodId && tc.UserId == currentUserId, false)
                                               .SumAsync(tc => tc.Amount);
            return usedAmount;
        }
    }
}
