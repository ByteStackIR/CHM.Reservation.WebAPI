namespace Services
{
    using System;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Entities.DataTransferObjects.Models;
    using Entities.IdentityExtensions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="SystemContext" />
    /// </summary>
    public class SystemContext : ISystemContext, IScopeMarker
    {
        /// <summary>
        /// Gets or sets the CurrentUser
        /// </summary>
        public ClaimsPrincipal CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets the UserCompany
        /// </summary>
        public CompanyDto UserCompany { get; set; } = null;

        /// <summary>
        /// Gets or sets the Period
        /// </summary>
        public PeriodDto Period { get; set; } = null;

        /// <summary>
        /// Gets or sets the RemainingCoupon
        /// </summary>
        public Decimal RemainingCoupon { get; set; } = 0;

        /// <summary>
        /// Gets or sets the RemainingCredit
        /// </summary>
        public Decimal RemainingCredit { get; set; } = 0;

        /// <summary>
        /// The InitializeSystemContext
        /// </summary>
        /// <param name="repositoryManager">The repositoryManager<see cref="IRepositoryManager"/></param>
        /// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <returns>The <see cref="Task"/></returns>
        public async Task InitializeSystemContext(
            IRepositoryManager repositoryManager,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper
        )
        {
            CurrentUser = httpContextAccessor.HttpContext.User;

            var periodModel =await repositoryManager
                .Period.PickNewest(
                    x => !x.IsDeleted && (x.StartDate <= DateTime.Now && x.EndDate >= DateTime.Now)
                )
               
             ;

            if (periodModel is not null)
                this.Period = mapper.Map<PeriodDto>(periodModel);

            if (CurrentUser.Identity.IsAuthenticated)
            {
                string UserId = CurrentUser.GetUserId().Value.ToString();

                var userCompany =await repositoryManager
                    .UserCompany.GetWithCompany(x => x.IsActive && x.UserId == UserId)
                ;
                this.UserCompany = mapper.Map<CompanyDto>(userCompany.Company);

                if (this.Period is not null && this.UserCompany is not null)
                {
                    decimal UsedCoupon = await repositoryManager
                        .Tx_Coupon.GetUsedByUser(
                            tc => tc.PeriodId == this.Period.Id && tc.UserId == UserId
                        )
                    ;

                    decimal UsedCredit = await repositoryManager
                        .Tx_Credit.GetUsedByUser(
                            tc => tc.PeriodId == this.Period.Id && tc.UserId == UserId
                        )
                       ;
                    this.RemainingCoupon = this.Period.Stipend - UsedCoupon;

                    this.RemainingCredit = this.Period.Credit - UsedCredit;
                }
                else
                {
                    this.RemainingCoupon = 0;
                    this.RemainingCredit = 0;
                }
            }
        }
    }
}
