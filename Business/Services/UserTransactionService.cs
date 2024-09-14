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
    class UserTransactionService : ServiceBase,IUserTransactionService, IScopeMarker
    {
        public UserTransactionService(
        IMapper mapper,
        ILoggerManager logger,
        IRepositoryManager repoManger,
        IHttpContextAccessor httpContextAccessor,
        ISystemContext systemContext
    )
        : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }
        public async Task<Tx_UserDto> AddTransaction(Internal_TransactionDto dto)
        {
            Tx_UserDto resDto = _mapper.Map<Tx_UserDto>( dto );
            resDto.Id = Guid.NewGuid();
            resDto.CreatedDate = DateTime.Now;

            var model = _mapper.Map<Tx_User>(dto);
            _repositoryManager.Tx_User.Create(model);

            _repositoryManager.Save();
            return resDto;
        }
    }
}
