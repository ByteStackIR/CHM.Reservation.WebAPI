namespace Services.Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Contracts.IService;
    using Entities.Constant;
    using Entities.DataTransferObjects.Models;
    using Entities.QueryExtensions;
    using Features.CustomRequest;
    using Features.RequestFeatures;
    using LoggerService;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="SlotService" />
    /// </summary>
    public class SlotService : ServiceBase, ISlotService, IScopeMarker
    {
        /// <summary>
        /// Defines the _EntityService
        /// </summary>
        internal IEntityService _EntityService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlotService"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
        /// <param name="repoManger">The repoManger<see cref="IRepositoryManager"/></param>
        /// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="EntityService">The EntityService<see cref="IEntityService"/></param>
        /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
        public SlotService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            IEntityService EntityService,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _EntityService = EntityService;
        }

        /// <summary>
        /// The GetPagedAvailableSlotsAsync
        /// </summary>
        /// <param name="request">The request<see cref="SlotRequest"/></param>
        /// <returns>The <see cref="Task{PagedData{List{SlotDto}}}"/></returns>
        public async Task<PagedData<List<SlotDto>>> GetPagedAvailableSlotsAsync(SlotRequest request)
        {
            var query = _repositoryManager.Slot.FindByCondition(
                s => s.EntityId == request.EntityId,
                false
            );
            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<SlotDto>>(data);

            foreach (var slot in dataDto)
            {
                //TODO: a condtion for states should be added too
                //FIX: test
                var reserves = _repositoryManager
                    .Reservation.FindByCondition(
                        y =>
                            (
                                y.IsFinalized
                                && (
                                    y.ObjectStateId
                                        != Guid.Parse(CancelStateConstant.HotelCancelState)
                                    && y.ObjectStateId
                                        != Guid.Parse(CancelStateConstant.TourCancelState)
                                )
                            ) || (y.IsFinalized == false && y.ExpirationDate >= DateTime.Now),
                        false
                    )
                    .Include(x => x.SelectedRelatives)
                //.Include(r => r.ObjectState)
                ; //TODO: condition to be added!!! filter only on those that are final

                var occupancy = await reserves.Select(x => x.SelectedRelatives.Count()).SumAsync();
                slot.Occupancy = occupancy;
            }

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        /// <summary>
        /// The GetOccupancyBySlotId
        /// </summary>
        /// <param name="Id">The Id<see cref="Guid"/></param>
        /// <returns>The <see cref="Task{int}"/></returns>
        public async Task<int> GetOccupancyBySlotId(Guid Id)
        {
            //TODO: a condtion for states should be added too
            var count = await _repositoryManager
                .Reservation.FindByCondition(r => r.SlotId == Id, false)
                .Include(r => r.ObjectState)
                .ThenInclude(o => o.ReservationStates)
                .Include(x => x.SelectedRelatives)
                .SelectMany(x => x.SelectedRelatives)
                .CountAsync();

            return (int)count;
        }

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="Id">The Id<see cref="Guid"/></param>
        /// <returns>The <see cref="Task{SlotDto}"/></returns>
        public async Task<SlotDto> GetById(Guid Id)
        {
            var slot = await _repositoryManager.Slot.GetByIdAsync(Id);

            var dataDto = _mapper.Map<SlotDto>(slot);
            return dataDto;
        }
    }
}
