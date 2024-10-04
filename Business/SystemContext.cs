namespace Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Entities.DataTransferObjects.Models;
    using Entities.IdentityExtensions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

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

            var periodModel = repositoryManager
                .Period.FindByCondition(
                    x => !x.IsDeleted && (x.StartDate <= DateTime.Now && x.EndDate >= DateTime.Now),
                    false
                )
                .OrderByDescending(x => x.CreatedDate)
                .FirstOrDefault();
            if (periodModel != null)
                this.Period = mapper.Map<PeriodDto>(periodModel);

            if (CurrentUser.Identity.IsAuthenticated)
            {
                var userCompany = repositoryManager
                    .UserCompany.FindByCondition(
                        x => x.IsActive && x.UserId == CurrentUser.GetUserId().Value.ToString(),
                        false
                    )
                    .Include(x => x.Company)
                    .FirstOrDefault();
                if (userCompany != null)
                {
                    this.UserCompany = mapper.Map<CompanyDto>(userCompany.Company);

                    this.RemainingCoupon = (
                        this.Period.Stipend
                        - await repositoryManager
                            .Tx_Coupon.FindByCondition(
                                tc =>
                                    tc.PeriodId == this.Period.Id
                                    && tc.UserId == CurrentUser.GetUserId().Value.ToString(),
                                false
                            )
                            .SumAsync(tc => tc.Amount)
                    );

                    this.RemainingCredit = (
                        this.Period.Credit
                        - await repositoryManager
                            .Tx_Credit.FindByCondition(
                                tc =>
                                    tc.PeriodId == this.Period.Id
                                    && tc.UserId == CurrentUser.GetUserId().Value.ToString(),
                                false
                            )
                            .SumAsync(tc => tc.Amount)
                    );
                }
            }

            return;
        }
    }
}
