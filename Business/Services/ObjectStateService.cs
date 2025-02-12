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
using Entities.DataTransferObjects.Models;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    public class ObjectStateService : ServiceBase, IObjectStateService,IScopeMarker
    {
        public ObjectStateService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<List<ObjectStateDto>> GetByCategoryId(Guid CategoryId)
        {
            var States =await _repositoryManager.ObjectStates.FindAll(x => x.CategoryId == CategoryId);

            var res = _mapper.Map<List<ObjectStateDto>>(States);
            return res;
        }

        public async Task<ObjectStateDto> GetNextStateByState(ObjectStateDto dto)
        {
            if (dto.NextNode == null)
                return null;

            var State = await _repositoryManager.ObjectStates.FirstOrDefaultAsync(x => x.CategoryId == dto.CategoryId && x.Code == dto.NextNode);

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetPreviousStateByState(ObjectStateDto dto)
        {
            if (dto.PreviousNode == null)
                return null;

            var State = await _repositoryManager.ObjectStates.FirstOrDefaultAsync(x => x.CategoryId == dto.CategoryId && x.Code == dto.PreviousNode);

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStateByCode(Guid CategoryId, int Code)
        {
          

            var State = await _repositoryManager.ObjectStates.FirstOrDefaultAsync(x => x.CategoryId == CategoryId && x.Code == Code);

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStateById(Guid Id)
        {
            var State = await _repositoryManager.ObjectStates.FirstOrDefaultAsync(x => x.Id==Id);

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStartStateByCategoryId(Guid CategoryId)
        {
            var State = await _repositoryManager.ObjectStates.FirstOrDefaultAsync(x => x.CategoryId== CategoryId && x.IsStartNode);

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }
    }
}
