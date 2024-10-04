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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Services.Services
{
    class CreditTransactionService : ServiceBase,ICreditTransactionService, IScopeMarker
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
            Tx_CreditDto resDto = _mapper.Map<Tx_CreditDto>( dto );
            resDto.Id = Guid.NewGuid();
            resDto.CreatedDate = DateTime.Now;

            var model = _mapper.Map<Tx_Credit>(resDto);
            _repositoryManager.Tx_Credit.Create(model);

            _repositoryManager.Save();
            return resDto;
        }
    }
}
