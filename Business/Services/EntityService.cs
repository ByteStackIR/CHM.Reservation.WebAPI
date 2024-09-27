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
            var query = _repositoryManager
                .Entity.FindByCondition(e => e.StartDate <= now && e.EndDate >= now, false)
                .Include(e => e.Category)
                .Include(e => e.ParameterValues);

            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<EntityDto>>(data);

            for (int i = 0; i < data.Count; i++)
            {
                dataDto[i].Category = _mapper.Map<CategoryDto>(data[i].Category);
            }
            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<EntityDataDto> GetSpecifiedEntityAsync(Guid EntityId)
        {
            //TODO: Add State Condition
            //NOTE: NOTE
            var now = DateTime.Now;
            var query = _repositoryManager
                .Entity.FindByCondition(e => e.Id == EntityId, false)
                .Include(x => x.City)
                .Include(e => e.Category)
                .Include(e => e.ParameterValues.OrderBy(x => x.DisplayOrder))
                .ThenInclude(x => x.Parameter)
                .Include(e => e.Slots)
                .ThenInclude(x =>
                    x.Reservations.Where(reservation =>
                        (
                            reservation.IsFinalized
                            && (
                                reservation.ObjectStateId
                                    != Guid.Parse(CancelStateConstant.HotelCancelState)
                                && reservation.ObjectStateId
                                    != Guid.Parse(CancelStateConstant.TourCancelState)
                            )
                        )
                        || (
                            reservation.IsFinalized == false
                            && reservation.ExpirationDate >= DateTime.Now
                        )
                    )
                )
                .ThenInclude(x =>
                    x.SelectedRelatives
                );

            var data = await query.FirstOrDefaultAsync();
            var SLots = _mapper.Map<List<SlotDto>>(data.Slots);

            foreach (var item in SLots)
            {
                item.Occupancy = data
                    .Slots.FirstOrDefault(y => y.Id == item.Id)
                    .Reservations.Select(x => x.SelectedRelatives.Count)
                    .Sum();
            }

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
            var query = _repositoryManager
                .Entity.FindAll(false)
                .Include(x => x.Category)
                .OrderByDescending(x => x.StartDate);

            var count = await query.CountAsync();

            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<EntityDto>>(data);

            for (int i = 0; i < data.Count; i++)
            {
                dataDto[i].Category = _mapper.Map<CategoryDto>(data[i].Category);
            }

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<EntityDto> GetEntityByIdAsync(Guid entityId)
        {
            try
            {
                var entity = await _repositoryManager
                    .Entity.FindByCondition(x => x.Id == entityId, false)
                    .Include(x => x.Slots)
                    .Include(x => x.ParameterValues)
                    .Include(x => x.EntityManagers)
                    .FirstOrDefaultAsync();
                if (entity is not null)
                {
                    var res = _mapper.Map<EntityDto>(entity);
                    res.Slots = _mapper.Map<List<SlotDto>>(entity.Slots);
                    res.ParameterValues = _mapper.Map<List<ParameterValuesDto>>(
                        entity.ParameterValues
                    );
                    res.EntityManagers = entity.EntityManagers.Select(x => x.Id).ToList();

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
                    .Entity.FindByCondition(x => x.Id == entityId, false)
                    .Include(x => x.ParameterValues.OrderBy(x => x.DisplayOrder))
                    .ThenInclude(x => x.Parameter)
                    .Include(x => x.Slots)
                    .FirstOrDefaultAsync();

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
                _repositoryManager.EntityManager.SaveChanges();
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

            var entityManagers = _repositoryManager
                .EntityManager.FindByCondition(tc => tc.EntityId == entity.Id, false)
                .ToList();
            foreach (var manager in entityManagers)
            {
                _repositoryManager.EntityManager.Delete(manager);
                _repositoryManager.EntityManager.SaveChanges();
            }

            foreach (var entityManagerId in entityDto.EntityManagers)
            {
                EntityManager entityManager = new EntityManager();
                entityManager.Id = Guid.NewGuid();
                entityManager.UserId = entityManager.ToString();
                entityManager.User = await _userManager.FindByIdAsync(entityManagerId.ToString());
                entityManager.EntityId = entity.Id;
                _repositoryManager.EntityManager.Create(entityManager);
                _repositoryManager.EntityManager.SaveChanges();
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
                    entity.ParameterValues.Add(paramValue);
                }
                else
                {
                    var paramValue = await _repositoryManager.ParameterValues.GetByIdAsync(
                        paramValueDto.Id
                    );
                    paramValue.Value = paramValueDto.Value;
                    paramValue.DisplayOrder = paramValueDto.DisplayOrder;
                    _repositoryManager.Entity.Update(entity);
                }
            }

            _repositoryManager.Entity.Update(entity);
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
