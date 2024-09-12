using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;

namespace Services.Services
{
    public class ReservationService : ServiceBase, IReservationService
    {
        public ISlotService _slotService;

        public ReservationService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
            ISlotService slotService
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _slotService = slotService;
        }

        public async Task<Internal_ReservationDto> InitReservation(ReservationCreationDto dto)
        {
            if (dto.Relatives.Distinct().Count() != dto.Relatives.Count())
                throw new Exception("re Item !");

            var SlotItem = await _slotService.GetById(dto.SlotId);

            int Occupancy = await _slotService.GetOccupancyBySlotId(dto.SlotId);

            if (SlotItem.Occupancy >= SlotItem.Capacity)
                throw new Exception("This slot is full!");

            if (SlotItem.Occupancy + dto.Relatives.Count >= SlotItem.Capacity)
                throw new Exception(
                    $"There are only {SlotItem.Capacity - SlotItem.Occupancy} for this Slot"
                );

            var EntityModel = await _repositoryManager.Entity.GetByIdAsync(SlotItem.EntityId);

            EntityDto Entity = _mapper.Map<EntityDto>(EntityModel);

            List<SelectedRelatives> selectedRelatives = new List<SelectedRelatives>();

            var relatives = await _repositoryManager.Relatives.GetRelatives(dto.Relatives);

            if (
                relatives
                    .Where(x => x.UserId == _systemContext.CurrentUser.GetUserId().ToString())
                    .Count() == dto.Relatives.Count
            )
                throw new Exception($"There are invalid relatives!");

            var Shares = await CalculateShares(_mapper.Map<List<RelativeDto>>(relatives),Entity);

            Internal_ReservationDto result = new Internal_ReservationDto()
            {
                Id = null,
                Amount = relatives.Count() * Entity.PerPerson,
                BillAmount = Shares.Select(x => x.UserShare).Sum(),
                ObjectStateId = null,
                CreatedDate = DateTime.Now,
                Shares = Shares,
                SlotId = SlotItem.Id,
                UserId = _systemContext.CurrentUser.GetUserId().ToString()
            };

            
            return result;
        }

        private async Task<Internal_ShareDto> CalculateShare(RelativeDto Relative, EntityDto Entity)
        {
            var Shares = await _repositoryManager.CouponShare.GetRelationSharesInPeriod(
                new() { Relative.RelationId },
                _systemContext.Period.Id
            );

            Internal_ShareDto res = new();

            var share = Shares.FirstOrDefault(x => x.RelationId == x.RelationId);

            Decimal CompanyShare = Entity.PersonShare * share.Entitlement / 100;

            res = new()
            {
                CompanyShare = CompanyShare,
                UserShare = Entity.PersonShare - CompanyShare,
                CouponShareId = share.Id,
                Relative = Relative,
            };

            return res;
        }

        private async Task<List<Internal_ShareDto>> CalculateShares(
            List<RelativeDto> Relatives,
            EntityDto Entity
        )
        {
            var Shares = await _repositoryManager.CouponShare.GetRelationSharesInPeriod(
                Relatives.Select(x => x.RelationId).ToList(),
                _systemContext.Period.Id
            );

            List<Internal_ShareDto> res = new List<Internal_ShareDto>();

            foreach (var Relative in Relatives)
            {
                var share = Shares.FirstOrDefault(x => x.RelationId == x.RelationId);

                Decimal CompanyShare = Entity.PersonShare * share.Entitlement / 100;

                res.Add(
                    new()
                    {
                        CompanyShare = CompanyShare,
                        UserShare = Entity.PersonShare - CompanyShare,
                        CouponShareId = share.Id,
                        Relative = Relative,
                    }
                );
            }

            return res;
        }
    }
}
