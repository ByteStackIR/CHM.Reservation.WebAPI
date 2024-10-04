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
    public class SystemContext : ISystemContext, IScopeMarker
    {

        public ClaimsPrincipal CurrentUser { get; set; }

        public CompanyDto UserCompany { get; set; } = null;
        public PeriodDto Period { get; set; } = null;

        public Decimal RemainingCoupon { get; set; } = 0;
        public Decimal RemainingCredit { get; set; } = 0;



        public async Task InitializeSystemContext(IRepositoryManager repositoryManager, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {

            CurrentUser = httpContextAccessor.HttpContext.User;


            var periodModel = repositoryManager.Period.FindByCondition(x => !x.IsDeleted && (x.StartDate <= DateTime.Now && x.EndDate >= DateTime.Now), false).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            if (periodModel != null)
                this.Period = mapper.Map<PeriodDto>(periodModel);


            if (CurrentUser.Identity.IsAuthenticated)
            {
                var userCompany = repositoryManager.UserCompany.FindByCondition(x => x.IsActive && x.UserId == CurrentUser.GetUserId().Value.ToString(), false).Include(x => x.Company).FirstOrDefault();
                if (userCompany != null)
                {
                    this.UserCompany = mapper.Map<CompanyDto>(userCompany.Company);


                    this.RemainingCoupon = (this.Period.Stipend - await repositoryManager.Tx_Coupon.FindByCondition(tc => tc.PeriodId == this.Period.Id && tc.UserId == CurrentUser.GetUserId().Value.ToString(), false)
                                              .SumAsync(tc => tc.Amount));

                    this.RemainingCredit = (this.Period.Credit - await repositoryManager.Tx_Credit.FindByCondition(tc => tc.PeriodId == this.Period.Id && tc.UserId == CurrentUser.GetUserId().Value.ToString(), false)
                                              .SumAsync(tc => tc.Amount));

                }
            }



            return;
        }



    }
}
