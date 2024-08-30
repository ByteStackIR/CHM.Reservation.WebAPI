using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EntityService : ServiceBase, IEntityService, IScopeMarker
    {
        public EntityService(IMapper mapper,
                             ILoggerManager logger,
                             IRepositoryManager repoManger,
                             IHttpContextAccessor httpContextAccessor,
                             ISystemContext systemContext) : base(repoManger,
                                                                  mapper,
                                                                  httpContextAccessor,
                                                                  systemContext,
                                                                  logger)
        { }

        public async Task<EntityDto> GetEntityByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repositoryManager.Entity.GetByIdAsync(entityId);
                if (entity is not null)
                {
                    return _mapper.Map<EntityDto>(entity);
                }
                else
                {
                    throw new Exception($"An Entity with Id:{entityId} could not found");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EntityDto> AddEntityAsync(EntityDto entityDto)
        {
            var category = await _repositoryManager.Category.GetByIdAsync(entityDto.CategoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }

            var entity = _mapper.Map<Entity>(entityDto);
            entity.Id = Guid.NewGuid();
            entity.CreatedDate = DateTime.Now;
            entity.UserId = _systemContext.CurrentUser.ToString();

            entity.ParameterValues = new List<ParameterValues>();
            foreach (var paramValueDto in entityDto.ParameterValues) 
            {
                var parameter = await _repositoryManager.Parameter.GetByIdAsync(paramValueDto.ParameterId);
                if (parameter == null)
                {
                    throw new Exception($"Parameter with ID {paramValueDto.ParameterId} not found");
                }

                var paramValue = new ParameterValues
                {
                    Id = Guid.NewGuid(),
                    ParameterId = paramValueDto.ParameterId,
                    EntityId = entity.Id,
                    Value = paramValueDto.Value,
                    CreatedDate = DateTime.Now,
                }; 

                entity.ParameterValues.Add(paramValue);
            }

            _repositoryManager.Entity.Create(entity);
            _repositoryManager.Save();

            return _mapper.Map<EntityDto>(entity);
        }

    }
}
