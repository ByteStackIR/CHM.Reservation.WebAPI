using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
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
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SlotService : ServiceBase, ISlotService, IScopeMarker
    {
        public SlotService(IMapper mapper,
                           ILoggerManager logger,
                           IRepositoryManager repoManger,
                           IHttpContextAccessor httpContextAccessor,
                           ISystemContext systemContext)
        : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<PagedData<List<SlotDto>>> GetPagedAvailableSlotsAsync(SlotRequest request)
        {
            var query = _repositoryManager.Slot.FindByCondition(s => s.EntityId == request.EntityId,false);
            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<SlotDto>>(data);

            foreach ( var slot in dataDto )
            {
                //TODO: a condtion for states should be added too
                //FIX: test
                var reserves = _repositoryManager.Reservation.FindByCondition(
                    r => r.SlotId == slot.Id,
                    false).Include(r => r.ObjectState).ThenInclude(o => o.ReservationStates); //TODO: condition to be added!!! filter only on those that are final

                var occupancy = await reserves.CountAsync();
                slot.Occupancy = occupancy;
            }

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }


        public async Task<SlotDto> GetOccupancyBySlotId(Guid Id)
        {
            return default;
        }

    }
}
