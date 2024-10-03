
using AutoMapper;
using Contracts.IContext;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.External;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Services.Services
{
    public class ReservationService : ServiceBase, IReservationService
    {
        private ISlotService _slotService;
        private IObjectStateService _ObjectStateService;
        private IRelationsService _relationsService;
        private IUserTransactionService _userTxService;
        private ICouponTransactionService _couponTxService;

        public ReservationService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
            ISlotService slotService,
            IObjectStateService ObjectStateService,
            IRelationsService RelationsService,
            IUserTransactionService userTx,
            ICouponTransactionService couponTx
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _slotService = slotService;
            _ObjectStateService = ObjectStateService;
            _relationsService = RelationsService;
            _userTxService = userTx;
            _couponTxService = couponTx;
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

            var relatives = await _repositoryManager.Relatives.GetRelatives(dto.Relatives);

            if (
                relatives
                    .Where(x => x.UserId == _systemContext.CurrentUser.GetUserId().ToString())
                    .Count() != dto.Relatives.Count
            )
                throw new Exception($"There are invalid relatives!");

            var Shares = await CalculateShares(
                _mapper.Map<List<RelativeDto>>(relatives),
                Entity,
                SlotItem
            );

            Internal_ReservationDto result = new Internal_ReservationDto()
            {
                Id = null,
                Amount = relatives.Count() * Entity.PerPerson,
                BillAmount = Shares.Select(x => x.UserShare).Sum(),
                ObjectStateId = null,
                CreatedDate = DateTime.Now,
                Shares = Shares,
                SlotId = SlotItem.Id.Value,
                CategoryId = Entity.CategoryId,
                EntityId = Entity.Id.Value,
                UserId = _systemContext.CurrentUser.GetUserId().ToString(),
            };

            return result;
        }

        public async Task<Internal_ReservationDto> CreateTemporaryReservation(
            Internal_ReservationDto dto
        )
        {
            try
            {
                dto.Id = Guid.NewGuid();

                List<SelectedRelatives> selectedRelatives = new List<SelectedRelatives>();

                foreach (var Share in dto.Shares)
                {
                    SelectedRelatives Person =
                        new()
                        {
                            Id = Guid.NewGuid(),
                            RelativeId = Share.Relative.Id.Value,
                            ReservationId = dto.Id.Value,
                            CreatedDate = DateTime.Now,
                        };

                    selectedRelatives.Add(Person);
                }

                dto.IsFinalized = false;
                dto.ExpirationDate = DateTime.Now.AddMinutes(15);

                dto.ObjectStateId = (
                    await _ObjectStateService.GetStartStateByCategoryId(dto.CategoryId)
                ).Id;

                ReservationDto Intermediate = _mapper.Map<ReservationDto>(dto);

                Reservation model = _mapper.Map<Reservation>(Intermediate);

                model.SelectedRelatives = selectedRelatives;
                //model.TxCoupons = null;
                //model.TxUsers = null;
                //model.ReservationStates = null;

                _repositoryManager.Reservation.Create(model);
                _repositoryManager.Reservation.SaveChanges();

                return dto;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<External_TempReservationDto> AddReservation(ReservationCreationDto dto)
        {
            Guid? preReservation = (
                await GetTemporaryReservationId(_systemContext.CurrentUser.GetUserId().Value)
            );

            if (preReservation.HasValue)
                await CancelTemporaryReservation(preReservation.Value);

            var interResult = await InitReservation(dto);

            var res = await CreateTemporaryReservation(interResult);

            External_TempReservationDto result =
                new()
                {
                    Amount = interResult.Amount,
                    BillAmount = interResult.BillAmount,
                    ExpirationDate = res.ExpirationDate,
                    Id = res.Id.Value,
                    Relatives = new(),
                };

            var AllRelations = await _relationsService.GetRelations();
            interResult.Shares.ForEach(share =>
            {
                result.Relatives.Add(
                    new()
                    {
                        Amount = share.CompanyShare + share.UserShare,
                        BillAmount = share.UserShare,
                        FirstName = share.Relative.FirstName,
                        LastName = share.Relative.FamilyName,
                        RelationTitle = AllRelations
                            .FirstOrDefault(x => x.Id == share.Relative.RelationId)
                            .Title,
                    }
                );
            });

            return result;
        }

        public async Task<bool> FinalizeReservation(Guid Id)
        {
            var ReservationModel = await _repositoryManager.Reservation.GetByIdAsync(Id);

            if (ReservationModel == null)
                throw new Exception("Not found");

            if (ReservationModel.UserId != _systemContext.CurrentUser.GetUserId().Value.ToString())
                throw new Exception("is not yours");

            if (ReservationModel.IsFinalized)
                throw new Exception("Finalized already");

            if (ReservationModel.ExpirationDate <= DateTime.Now)
            {
                _repositoryManager.Reservation.Delete(ReservationModel);
                _repositoryManager.Save();
                throw new Exception("has expired");
            }

            ReservationModel.IsFinalized = true;

            _repositoryManager.ReservationStates.Create(
                new ReservationStates()
                {
                    ObjectStateId = ReservationModel.ObjectStateId,
                    IsDone = true,
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    ActorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    CreatedDate = DateTime.Now,
                    ToForward = true,
                    ReservationId = ReservationModel.Id,
                    Id = Guid.NewGuid(),
                    IsCancelled = false,
                }
            );

            var NextState = await _ObjectStateService.GetNextStateByState(
                await _ObjectStateService.GetStateById(ReservationModel.ObjectStateId)
            );
            _repositoryManager.ReservationStates.Create(
                new ReservationStates()
                {
                    ObjectStateId = NextState.Id,
                    IsDone = false,
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    CreatedDate = DateTime.Now,
                    ToForward = true,
                    ReservationId = ReservationModel.Id,
                    Id = Guid.NewGuid(),
                    IsCancelled = false,
                }
            );

            ReservationModel.ObjectStateId = NextState.Id;
            _repositoryManager.Save();
            await _couponTxService.AddTransaction(
                new()
                {
                    Amount = ReservationModel.Amount - ReservationModel.BillAmount,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PeriodId = _systemContext.Period.Id,
                    ReservationId = ReservationModel.Id,
                    UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                }
            );

            await _userTxService.AddTransaction(
                new()
                {
                    Amount = ReservationModel.BillAmount,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PeriodId = _systemContext.Period.Id,
                    ReservationId = ReservationModel.Id,
                    UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                }
            );
            _repositoryManager.Reservation.Update(ReservationModel);

            return true;
        }

        public async Task<Guid?> GetTemporaryReservationId(Guid UserId)
        {
            var tempoReservation = await _repositoryManager
                .Reservation.FindByCondition(
                    x =>
                        x.UserId == UserId.ToString()
                        && x.IsFinalized == false
                        && x.ExpirationDate > DateTime.Now,
                    false
                )
                .FirstOrDefaultAsync();

            return tempoReservation?.Id;
        }

        public async Task<External_TempReservationDto> GetTemporaryReservation(Guid UserId)
        {
            var tempoReservation = await _repositoryManager
                .Reservation.FindByCondition(
                    x =>
                        x.UserId == UserId.ToString()
                        && x.IsFinalized == false
                        && x.ExpirationDate > DateTime.Now,
                    false
                )
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative)
                .Include(x => x.Slot.Entity)
                .FirstOrDefaultAsync();

            External_TempReservationDto result =
                new()
                {
                    Amount = tempoReservation.Amount,
                    BillAmount = tempoReservation.BillAmount,
                    ExpirationDate = tempoReservation.ExpirationDate,
                    Id = tempoReservation.Id,
                    Relatives = new(),
                };

            var Shares = await CalculateShares(
                _mapper.Map<List<RelativeDto>>(
                    tempoReservation.SelectedRelatives.Select(x => x.Relative).ToList()
                ),
                _mapper.Map<EntityDto>(tempoReservation.Slot.Entity),
                _mapper.Map<SlotDto>(tempoReservation.Slot)
            );

            var AllRelations = await _relationsService.GetRelations();
            Shares.ForEach(share =>
            {
                result.Relatives.Add(
                    new()
                    {
                        Amount = share.CompanyShare + share.UserShare,
                        BillAmount = share.UserShare,
                        FirstName = share.Relative.FirstName,
                        LastName = share.Relative.FamilyName,
                        RelationTitle = AllRelations
                            .FirstOrDefault(x => x.Id == share.Relative.RelationId)
                            .Title,
                    }
                );
            });

            return result;
        }

        public async Task<Internal_ShareDto> CalculateShare(RelativeDto Relative, EntityDto Entity)
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

        public async Task<List<Internal_ShareDto>> CalculateShares(
            List<RelativeDto> Relatives,
            EntityDto Entity,
            SlotDto slot
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
                //TODO : کمتر از دو سال کلا هزینه آن برای شرکت و کاربر صفر است یا چی؟
                int age = 0;
                age = slot.StartDate.Date.Year - Relative.BirthDate.Date.Year;
                if (DateTime.Now.DayOfYear < Relative.BirthDate.Date.DayOfYear)
                    age = age - 1;

                if (age >= Entity.MinAge)
                {
                    Decimal CompanyShare = Entity.PerPerson * share.Entitlement / 100;

                    res.Add(
                        new()
                        {
                            CompanyShare = CompanyShare,
                            UserShare = Entity.PerPerson - CompanyShare,
                            CouponShareId = share.Id,
                            Relative = Relative,
                        }
                    );
                }
                else
                {
                    res.Add(
                        new()
                        {
                            CompanyShare = 0,
                            UserShare = 0,
                            CouponShareId = share.Id,
                            Relative = Relative,
                        }
                    );
                }
            }

            return res;
        }

        public async Task<PagedData<List<ReservationDto>>> GetPagedReservationsOfUserAsync(
            ReservationRequest_User request
        )
        {
            var currentUser = _systemContext.CurrentUser.GetUserId().Value.ToString();
            var query = _repositoryManager
                .Reservation.FindByCondition(r => r.UserId == currentUser, false)
                .Include(r => r.Slot);
            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<ReservationDto>>(data);

            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<PagedData<List<ReservationDto>>> GetPagedReservationsOfHotelAsync(
            ReservationRequest_Hotel request
        )
        {
            var query = _repositoryManager
                .Reservation.FindByCondition(r => r.Slot.EntityId == request.EntityId, false)
                .Include(r => r.Slot)
                .Include(r => r.ReservationStates);

            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<ReservationDto>>(data);
            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task<PagedData<List<ReservationDto>>> GetPagedReservationOfExecutiveAsync(
            ReservationRequest_Executive request
        )
        {
            var currentUser = _systemContext.CurrentUser.GetUserId().Value.ToString();
            var query = _repositoryManager
                .Reservation.FindByCondition(
                    r =>
                        _repositoryManager
                            .EntityManager.FindByCondition(em => em.UserId == currentUser, false)
                            .Select(em => em.EntityId)
                            .Contains(r.Slot.EntityId),
                    false
                )
                .Include(r => r.Slot);

            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            var dataDto = _mapper.Map<List<ReservationDto>>(data);
            return new(new(count, request.PageNumber, request.PageSize), dataDto);
        }

        public async Task CancelTemporaryReservation(Guid ReservationId)
        {
            var tempoReservation = await _repositoryManager
                .Reservation.FindByCondition(x => x.Id == ReservationId, false)
                .Include(x => x.SelectedRelatives)
                .FirstOrDefaultAsync();

            foreach (var item in tempoReservation.SelectedRelatives)
                _repositoryManager.SelectedRelatives.Delete(item);

            _repositoryManager.Reservation.Delete(tempoReservation);

            _repositoryManager.Save();
        }
    }
}
