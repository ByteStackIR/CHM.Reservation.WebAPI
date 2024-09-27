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
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Services
{
    public class SlotService : ServiceBase, ISlotService, IScopeMarker
    {
        IEntityService _EntityService;
        public SlotService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            IEntityService EntityService,

            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) {

            _EntityService = EntityService;
        }

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
                    .Reservation.FindByCondition(r => r.SlotId == slot.Id && _EntityService.TrueReservation(r), false).Include(x=>x.SelectedRelatives)
                    //.Include(r => r.ObjectState)
                    ; //TODO: condition to be added!!! filter only on those that are final

                var occupancy = await reserves.Select(x=>x.SelectedRelatives.Count()).SumAsync();
                slot.Occupancy = occupancy;
            }

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<int> GetOccupancyBySlotId(Guid Id)
        {
            //TODO: a condtion for states should be added too
            var count = await _repositoryManager
                .Reservation.FindByCondition(r => r.SlotId == Id, false)
                .Include(r => r.ObjectState)
                .ThenInclude(o => o.ReservationStates)
                .Include(x => x.SelectedRelatives).SelectMany(x => x.SelectedRelatives).CountAsync();
        
            return (int)count;
        }

        public async Task<SlotDto> GetById(Guid Id)
        {

            var slot = await _repositoryManager.Slot.GetByIdAsync(Id);

            var dataDto = _mapper.Map<SlotDto>(slot);
            return dataDto;
        }
    }
}
