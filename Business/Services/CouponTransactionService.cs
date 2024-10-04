using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;

namespace Services.Services
{
    public class CouponTransactionService : ServiceBase, ICouponTransactionService, IScopeMarker
    {
        public CouponTransactionService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<Tx_CouponDto> AddTransaction(Internal_TransactionDto dto)
        {
            Tx_CouponDto resDto = _mapper.Map<Tx_CouponDto>(dto);
            resDto.Id = Guid.NewGuid();
            resDto.CreatedDate = DateTime.Now;

            var model = _mapper.Map<Tx_Coupon>(resDto);
            _repositoryManager.Tx_Coupon.Create(model);

            _repositoryManager.Save();
            return resDto;
        }

        public async Task<decimal> GetRemainingCoupon()
        {
            return _systemContext.RemainingCoupon;
        }
    }
}
