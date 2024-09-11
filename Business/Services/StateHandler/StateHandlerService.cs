using Contracts.IMarker;
using Contracts.IRepository;
using Entities.DataTransferObjects.Models;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService.IStateHandler
{
    public class StateHandlerService : IScopeMarker
    {
        private readonly IRepositoryManager _repositoryManager;

        private readonly IObjectStateService _objectStateService;

        private readonly ILoggerManager _loggerManager;
        public StateHandlerService(ILoggerManager loggerManager,IRepositoryManager repositoryManager,IObjectStateService objectStateService)
        {
            _repositoryManager = repositoryManager;
            _objectStateService = objectStateService;
            _loggerManager = loggerManager;
        }

        public async Task<ObjectStateDto> GenerateFirstStep(Guid CategoryId)
        {

            return null;
        }
    }
}
