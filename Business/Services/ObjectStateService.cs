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
            var States =await _repositoryManager.ObjectStates.FindByCondition(x => x.CategoryId == CategoryId, false).ToListAsync();

            var res = _mapper.Map<List<ObjectStateDto>>(States);
            return res;
        }

        public async Task<ObjectStateDto> GetNextStateByState(ObjectStateDto dto)
        {
            if (dto.NextNode == null)
                return null;

            var State = await _repositoryManager.ObjectStates.FindByCondition(x => x.CategoryId == dto.CategoryId && x.Code == dto.NextNode, false).FirstOrDefaultAsync();

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetPreviousStateByState(ObjectStateDto dto)
        {
            if (dto.PreviousNode == null)
                return null;

            var State = await _repositoryManager.ObjectStates.FindByCondition(x => x.CategoryId == dto.CategoryId && x.Code == dto.PreviousNode, false).FirstOrDefaultAsync();

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStateByCode(Guid CategoryId, int Code)
        {
          

            var State = await _repositoryManager.ObjectStates.FindByCondition(x => x.CategoryId == CategoryId && x.Code == Code, false).FirstOrDefaultAsync();

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStateById(Guid Id)
        {
            var State = await _repositoryManager.ObjectStates.FindByCondition(x => x.Id==Id, false).FirstOrDefaultAsync();

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }

        public async Task<ObjectStateDto> GetStartStateByCategoryId(Guid CategoryId)
        {
            var State = await _repositoryManager.ObjectStates.FindByCondition(x => x.CategoryId== CategoryId && x.IsStartNode, false).FirstOrDefaultAsync();

            var res = _mapper.Map<ObjectStateDto>(State);
            return res;
        }
    }
}
