using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.Constant;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    public class EntityService : ServiceBase, IEntityService, IScopeMarker
    {
        public readonly UserManager<User> _userManager;

        public EntityService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _userManager = userManager;
        }

        //===========PUBLIC AREA

        public async Task<PagedData<List<EntityDto>>> GetPagedCurrentEntitiesAsync(
            PublicEntitiesTableRequest request
        )
        {
            var now = DateTime.Now;
            var data = await _repositoryManager
                .Entity.GetPagedCurrentEntities(request);

     
            var dataDto = _mapper.Map<List<EntityDto>>(data);

            for (int i = 0; i < data.Data.Count; i++)
            {
                dataDto[i].Category = _mapper.Map<CategoryDto>(data.Data[i].Category);
            }
            return new(new(data.TotalCount, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<EntityDataDto> GetSpecifiedEntityAsync(Guid EntityId)
        {

         



            var data = await _repositoryManager
                .Entity.GetSpecifiedEntityAsync(EntityId);
            var SLots = _mapper.Map<List<SlotDto>>(data.Slots).OrderBy(x => x.StartDate).ToList();

            foreach (var item in SLots)
            {
                item.Occupancy = data
                    .Slots.FirstOrDefault(y => y.Id == item.Id)
                    .Reservations.Select(x => x.SelectedRelatives.Count)
                    .Sum();
            }
            var Images = await _repositoryManager.AttachmentsRepository.FindAll(x => x.ObjectId == EntityId);



            EntityDataDto res =
                new()
                {
                    minAge = (int)data.MinAge,
                    Id = data.Id,
                    Title = data.Title,
                    Slots = SLots,
                    Category = _mapper.Map<CategoryDto>(data.Category),
                    Attributes = new(),
                    StartDate = data.StartDate,
                    EndDate = data.EndDate,
                    PerPerson = data.PerPerson,
                    CityTitle = data.City.Title,
                    Images = Images.Select(x => x.Id.ToString()).ToList()
                };

            foreach (var item in data.ParameterValues)
            {
                res.Attributes.Add(
                    new()
                    {
                        PrameterId = item.ParameterId,
                        Title = item.Parameter.Title,
                        Value = item.Value,
                        ValueId = item.Id,
                        Type = item.Parameter.Type.ToString(),
                    }
                );
            }

            return res;
        }

        //====================================END OF PUBLIC AREA













        /// <summary>
        /// گرفتن هتل/تورها به صورت صفحه بندی شده -- سطح ادمین
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PagedData<List<EntityDto>>> GetPagedEntities(
            AdminEntitiesTableRequest request
        )
        {
            var query =await _repositoryManager
                .Entity.GetPagedEntities_Admin(request);

            var count = query.TotalCount;

            var data = query.Data;
            var dataDto = _mapper.Map<List<EntityDto>>(data);

            for (int i = 0; i < data.Count; i++)
            {
                dataDto[i].Category = _mapper.Map<CategoryDto>(data[i].Category);

                // adding images to entity
                var images = await _repositoryManager.AttachmentsRepository.FindAll(x => x.ObjectId == dataDto[i].Id);

                // TODO write a mapper to do the this
                dataDto[i].Images = new();
                foreach (var item in images)
                {
                    dataDto[i].Images.Add(new()
                    {
                        DisplayOrder = item.DisplayOrder,
                        FilePath = item.Id.ToString(),
                        Key = item.Id.ToString()
                    });
                }
                dataDto[i].Images = dataDto[i].Images.OrderBy(x => x.DisplayOrder).ToList();
            }

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<EntityDto> GetEntityByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repositoryManager
                    .Entity.GetEntityById_Admin(entityId);

                var images = await _repositoryManager.AttachmentsRepository.FindAll(x => x.ObjectId == entityId);

                if (entity is not null)
                {
                    var res = _mapper.Map<EntityDto>(entity);
                    res.Slots = res.Slots.OrderBy(x => x.StartDate).ToList();
                    res.ParameterValues = res.ParameterValues.OrderBy(x => x.DisplayOrder).ToList();
                    res.EntityManagers = entity.EntityManagers.Select(x => x.Id).ToList();

                    // TODO write a mapper to do the this
                    res.Images = new();
                    foreach (var item in images)
                    {
                        res.Images.Add(new()
                        {
                            DisplayOrder = item.DisplayOrder,
                            FilePath = item.Id.ToString(),
                            Key = item.Id.ToString()
                        });
                    }
                    res.Images = res.Images.OrderBy(x => x.DisplayOrder).ToList();
                    return res;
                }
                else
                {
                    throw new Exception($"An Entity with Id:{entityId} could not found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EntityDto> GetEntityInformationByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repositoryManager
                    .Entity.GetEntityInformationByIdAsync(entityId);

                if (entity is not null)
                {
                    var dto = _mapper.Map<EntityDto>(entity);
                    dto.ParameterValues = _mapper.Map<List<ParameterValuesDto>>(
                        entity.ParameterValues
                    );
                    dto.Slots = _mapper.Map<List<SlotDto>>(entity.Slots);
                    return dto;
                }
                else
                {
                    throw new Exception($"An Entity with Id:{entityId} could not found");
                }
            }
            catch (Exception ex)
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
            entity.UserId = _systemContext.CurrentUser.GetUserId().ToString();
            entity.Slots = new List<Slot>();
            entity.ParameterValues = new List<ParameterValues>();
            entity.PeriodId = _systemContext.Period.Id;
            foreach (var entityManagerId in entityDto.EntityManagers)
            {
                EntityManager entityManager = new EntityManager();
                entityManager.Id = Guid.NewGuid();
                entityManager.UserId = entityManager.ToString();
                entityManager.User = await _userManager.FindByIdAsync(entityManagerId.ToString());
                entityManager.EntityId = entity.Id;
                _repositoryManager.EntityManager.Create(entityManager);
                _repositoryManager.Save();
            }

            foreach (var Slot in entityDto.Slots)
            {
                var model = _mapper.Map<Slot>(Slot);
                model.Id = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.EntityId = entity.Id;

                entity.Slots.Add(model);
            }

            foreach (var paramValueDto in entityDto.ParameterValues)
            {
                var parameter = await _repositoryManager.Parameter.GetByIdAsync(
                    paramValueDto.ParameterId
                );
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
                    DisplayOrder = paramValueDto.DisplayOrder,
                };

                entity.ParameterValues.Add(paramValue);
            }

            _repositoryManager.Entity.Create(entity);
            _repositoryManager.Save();

            return _mapper.Map<EntityDto>(entity);
        }

        public async Task<EntityDto> UpdateEntityAsync(EntityDto entityDto)
        {
            var category = await _repositoryManager.Category.GetByIdAsync(entityDto.CategoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }

            var entity = await _repositoryManager.Entity.GetByIdAsync(entityDto.Id);
            entity.StartDate = entityDto.StartDate;
            entity.EndDate = entityDto.EndDate;
            entity.CategoryId = category.Id;
            entity.PeriodId = entity.PeriodId;
            entity.DaysToCancel = entityDto.DaysToCancel;
            entity.Cancelable = entityDto.Cancelable;
            entity.MaxReserveTimes = entityDto.MaxReserveTimes;
            entity.MinAge = entityDto.MinAge;
            entity.Title = entityDto.Title;
            entity.PerPerson = entityDto.PerPerson;
            entity.UserId = _systemContext.CurrentUser.GetUserId().ToString();
            entity.ParameterValues = new List<ParameterValues>();
            _repositoryManager.Entity.Update(entity);

            var entityManagers = await _repositoryManager
                .EntityManager.FindAll(tc => tc.EntityId == entity.Id)
               ;
            foreach (var manager in entityManagers)
            {
                _repositoryManager.EntityManager.Delete(manager);
                _repositoryManager.Save();
            }

            foreach (var entityManagerId in entityDto.EntityManagers)
            {
                EntityManager entityManager = new EntityManager();
                entityManager.Id = Guid.NewGuid();
                entityManager.UserId = entityManager.ToString();
                entityManager.User = await _userManager.FindByIdAsync(entityManagerId.ToString());
                entityManager.EntityId = entity.Id;
                _repositoryManager.EntityManager.Create(entityManager);
                _repositoryManager.Save();
            }

            foreach (var Slot in entityDto.Slots)
            {
                if (Slot.Id == null || Slot.Id == Guid.Empty)
                {
                    var model = _mapper.Map<Slot>(Slot);
                    model.Id = Guid.NewGuid();
                    model.CreatedDate = DateTime.Now;
                    model.EntityId = entity.Id;

                    _repositoryManager.Slot.Create(model);
                }
                else
                {
                    var model = await _repositoryManager.Slot.GetByIdAsync(Slot.Id);
                    model.StartDate = Slot.StartDate;
                    model.EndDate = Slot.EndDate;
                    model.Capacity = Slot.Capacity;

                    _repositoryManager.Slot.Update(model);
                }
            }

            foreach (var paramValueDto in entityDto.ParameterValues)
            {
                var parameter = await _repositoryManager.Parameter.GetByIdAsync(
                    paramValueDto.ParameterId
                );
                if (parameter == null)
                {
                    throw new Exception($"Parameter with ID {paramValueDto.ParameterId} not found");
                }

                if (paramValueDto.Id == null || paramValueDto.Id == Guid.Empty)
                {
                    var paramValue = new ParameterValues
                    {
                        Id = Guid.NewGuid(),
                        ParameterId = paramValueDto.ParameterId,
                        EntityId = entity.Id,
                        Value = paramValueDto.Value,
                        CreatedDate = DateTime.Now,
                        DisplayOrder = paramValueDto.DisplayOrder,
                    };
                    _repositoryManager.ParameterValues.Create(paramValue);
                }
                else
                {
                    var paramValue = await _repositoryManager.ParameterValues.GetByIdAsync(
                        paramValueDto.Id
                    );
                    paramValue.Value = paramValueDto.Value;
                    paramValue.DisplayOrder = paramValueDto.DisplayOrder;
                    _repositoryManager.ParameterValues.Update(paramValue);
                }
            }


            _repositoryManager.Save();

            return _mapper.Map<EntityDto>(entity);
        }

        public async Task DeleteEntityByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repositoryManager.Entity.GetByIdAsync(entityId);
                if (entity is not null)
                {
                    entity.IsDeleted = true;
                    _repositoryManager.Entity.Update(entity);
                    _repositoryManager.Save();
                }
                else
                {
                    throw new Exception($"An Entity with Id:{entityId} could not found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
