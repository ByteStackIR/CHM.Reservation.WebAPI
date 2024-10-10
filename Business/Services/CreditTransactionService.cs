using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    class CreditTransactionService : ServiceBase, ICreditTransactionService, IScopeMarker
    {
        public CreditTransactionService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<Tx_CreditDto> AddTransaction(Internal_TransactionDto dto)
        {
            Tx_CreditDto resDto = _mapper.Map<Tx_CreditDto>(dto);
            resDto.Id = Guid.NewGuid();
            resDto.CreatedDate = DateTime.Now;

            var model = _mapper.Map<Tx_Credit>(resDto);
            _repositoryManager.Tx_Credit.Create(model);

            _repositoryManager.Save();
            return resDto;
        }

        public async Task<Tx_CreditDto> AddTransaction(AddToCreditDto dto)
        {
            Tx_CreditDto resDto =
                new()
                {
                    Amount = dto.Amount,
                    ReservationId = null,
                    CreatedDate = DateTime.Now,
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    Description = dto.Description,
                    PeriodId = _systemContext.Period.Id,
                    UserId = dto.UserId.ToString(),
                };
            resDto.Id = Guid.NewGuid();
            resDto.CreatedDate = DateTime.Now;

            var model = _mapper.Map<Tx_Credit>(resDto);
            _repositoryManager.Tx_Credit.Create(model);

            _repositoryManager.Save();
            return resDto;
        }

        public async Task<decimal> GetRemainingCredit()
        {
            return _systemContext.RemainingCredit;
        }

        public async Task<decimal> GetUserRemainingCredit(Guid UserId)
        {
            return
                 _systemContext.Period.Credit -
                await _repositoryManager
                .Tx_Credit.FindByCondition(
                    x => x.PeriodId == _systemContext.Period.Id && x.UserId == UserId.ToString(),
                    true
                )
                .Select(x => x.Amount)
                .SumAsync();
        }
    }
}
