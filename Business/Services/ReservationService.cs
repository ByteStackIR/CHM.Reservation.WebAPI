using System.Collections.Generic;
using AutoMapper;
using Contracts.IContext;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.External;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.Enum;
using Entities.IdentityExtensions;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        private ICreditTransactionService _creditTxService;
        private IReservationStateService _reservationStateService;

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
            ICouponTransactionService couponTx,
            ICreditTransactionService creditTxService,
            IReservationStateService reservationStateService
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _slotService = slotService;
            _ObjectStateService = ObjectStateService;
            _relationsService = RelationsService;
            _userTxService = userTx;
            _couponTxService = couponTx;
            _creditTxService = creditTxService;
            _reservationStateService = reservationStateService;
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
                SlotItem,
                dto.Mode
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

            //NOTE: محل بررسی اینکه آیا کاربر اعتبار برای رزرو موقت دارد یا خیر
            //TODO: محل بررسی اعتبار در حین رزرو موقت
            //TODO: تغییر یافته برای بی اثر شدن محاسبات
            //if (!(_systemContext.RemainingCoupon >= (interResult.Amount - interResult.BillAmount)))
            if (
                !(
                    _systemContext.RemainingCoupon >= 1
                    || _systemContext.RemainingCredit >= interResult.Amount
                )
            )
                throw new Exception("You does not have enough credit to reserve the hotel/tour!");

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
                        //BillAmount = 0,
                        //TODO: تغییر یافته برای بی اثر شدن محاسبات
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

        public async Task<bool> FinalizeReservation(FinalizeReservationDto dto)
        {
            if (dto.Mode == null)
                throw new Exception("Mode must have value");

            var ReservationModel = await _repositoryManager.Reservation.GetByIdAsync(
                dto.TempoReservationId
            );

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

            if (ReservationModel.TransactionMode != dto.Mode)
            {
                if (
                    !(
                        ReservationModel.TransactionMode == TransactionMode.CouponMode
                        && dto.Mode == TransactionMode.CouponAndCreditMode
                    )
                )
                    throw new Exception("Invalid Transaction");
            }

            //TODO: محل بررسی اعتبار در حین رزرو اصلی
            //TODO: تغییر یافته برای بی اثر شدن محاسبات

            if (dto.Mode == TransactionMode.CouponMode)
            {
                //     !(_systemContext.RemainingCoupon>= (ReservationModel.Amount - ReservationModel.BillAmount))
                if (!(_systemContext.RemainingCoupon >= 1))
                    throw new Exception("user does not have enough coupon to pay");

                if ((ReservationModel.BillAmount != 0))
                    throw new Exception(
                        "you can not pay bill Amount for All crew member by coupon"
                    );
            }
            else if (dto.Mode == TransactionMode.CreditMode)
            {
                //!(_systemContext.RemainingCoupon >= (ReservationModel.Amount - ReservationModel.BillAmount)|| _systemContext.RemainingCredit >= ReservationModel.BillAmount )
                if (!(_systemContext.RemainingCredit >= ReservationModel.BillAmount))
                    throw new Exception(
                        "You does not have enough credit to reserve the hotel/tour!"
                    );
            }
            else if (dto.Mode == TransactionMode.CouponAndCreditMode)
            {
                if (!(_systemContext.RemainingCoupon >= 1))
                    throw new Exception("user does not have enough coupon to pay");

                if (!(_systemContext.RemainingCredit >= ReservationModel.BillAmount))
                    throw new Exception(
                        "You does not have enough credit to reserve the hotel/tour!"
                    );
            }

            ReservationModel.IsFinalized = true;
            ReservationModel.TransactionMode = dto.Mode;

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

            //TODO: تغییر یافته برای بی اثر شدن محاسبات
            // Decimal UserShare = ReservationModel.BillAmount;
            // Decimal CreditShare = ReservationModel.BillAmount;
            Decimal UserShare = ReservationModel.BillAmount;
            Decimal CreditShare = ReservationModel.Amount;
            Decimal CouponShare = 1;

            if (dto.Mode == TransactionMode.CouponMode)
            {
                //**
                //در حالت صرفا سرانه
                // سهم پرداختی برای کاربر 0
                // سهم سرانه 1
                // سهم اعتبار 0
                //*//
                CreditShare = 0;
                UserShare = 0;
            }
            else if (dto.Mode == TransactionMode.CreditMode)
            {
                //**
                //در حالت صرفا اعتبار
                // سهم پرداختی برای کاربر 0
                // سهم سرانه 0
                // سهم اعتبار = به اندازه کل هزینه
                //*//
                CouponShare = 0;
                UserShare = 0;
            }
            else if (dto.Mode == TransactionMode.CouponAndCreditMode)
            {
                //**
                //در حالت ترکیبی سرانه و اعتبار
                // سهم پرداختی برای کاربر 0
                // سهم سرانه 1
                // سهم اعتبار = به اندازه باقی هزینه
                //*//
                UserShare = 0;
                CreditShare = ReservationModel.BillAmount;
                CouponShare = 1;
            }

            await _couponTxService.AddTransaction(
                new()
                {
                    //TODO: تغییر یافته برای بی اثر شدن محاسبات
                    //Amount = ReservationModel.Amount - ReservationModel.BillAmount,
                    Amount = CouponShare,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PeriodId = _systemContext.Period.Id,
                    ReservationId = ReservationModel.Id,
                    UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    Description =
                        DateTime.Now.ToString("yyyy.MM.dd")
                        + " استفاده از سرانه بابت رزرو در تاریخ ",
                }
            );

            await _userTxService.AddTransaction(
                new()
                {
                    Amount = UserShare,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PeriodId = _systemContext.Period.Id,
                    ReservationId = ReservationModel.Id,
                    UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    Description =
                        " پرداختی به عهده کاربر نمیباشد! "
                        + DateTime.Now.ToString("yyyy.MM.dd")
                        + " به علت استفاده از سرانه، بابت رزرو در تاریخ ",
                }
            );

            await _creditTxService.AddTransaction(
                new Internal_TransactionDto()
                {
                    Amount = CreditShare,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PeriodId = _systemContext.Period.Id,
                    ReservationId = ReservationModel.Id,
                    UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                    Description =
                        DateTime.Now.ToString("yyyy.MM.dd") + " استفاده از اعتبار برای رزرو ",
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
                _mapper.Map<SlotDto>(tempoReservation.Slot),
                tempoReservation.TransactionMode
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
            SlotDto slot,
            TransactionMode TxMode
        )
        {
            var Shares = await _repositoryManager.CouponShare.GetRelationSharesInPeriod(
                Relatives.Select(x => x.RelationId).ToList(),
                _systemContext.Period.Id
            );

            List<Internal_ShareDto> res = new List<Internal_ShareDto>();

            List<RelationType> SelectedRelations = new();

            bool CouponShouldBe = (
                TxMode == TransactionMode.CouponMode
                || TxMode == TransactionMode.CouponAndCreditMode
            );

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
                    Decimal CompanyShare = 0;
                    //TODO: موارد جدیدا اضافه شده اند
                    //اگر از اون فامیلای درجه یک بود هیچی نخواد
                    if (
                        CouponShouldBe && await _relationsService.NeedConfirmation(share.RelationId)
                    )
                    {
                        if (
                            (
                                share.Relation.Type == RelationType.PEDAR
                                && SelectedRelations.Contains(RelationType.PEDAR2)
                            )
                            || (
                                share.Relation.Type == RelationType.PEDAR2
                                && SelectedRelations.Contains(RelationType.PEDAR)
                            )
                            || (
                                share.Relation.Type == RelationType.MADAR
                                && SelectedRelations.Contains(RelationType.MADAR2)
                            )
                            || (
                                share.Relation.Type == RelationType.MADAR2
                                && SelectedRelations.Contains(RelationType.MADAR)
                            )
                        )
                        {
                            CompanyShare = 0;
                        }
                        else
                        {
                            CompanyShare = Entity.PerPerson * 100 / 100;
                        }
                    }

                    //TODO: تغییر یافته برای بی اثر شدن محاسبات
                    //Decimal CompanyShare = Entity.PerPerson * share.Entitlement / 100;

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

                SelectedRelations.Add(share.Relation.Type);
            }

            return res;
        }

        public async Task<PagedData<List<External_ReservationDto>>> GetPagedReservationsOfUserAsync(
            ReservationRequest_User request
        )
        {
            var currentUser = _systemContext.CurrentUser.GetUserId().Value.ToString();
            var query = _repositoryManager
                .Reservation.FindByCondition(r => r.UserId == currentUser, false)
                .Include(r => r.Slot.Entity.Category)
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative.Relation)
                .Include(x =>
                    x.ReservationStates.OrderByDescending(y => y.CreatedDate).Take(1)
                )
                .ThenInclude(x => x.ObjectState)
                .OrderByDescending(x => x.CreatedDate);

            var asfdsadf = query.ToQueryString();

            List<External_ReservationDto> result = new();
            var count = await query.CountAsync();
            var data = await query.GetPage(request).ToListAsync();
            data.ForEach(item =>
            {
                result.Add(
                    new()
                    {
                        Id = item.Id,
                        Amount = item.Amount,
                        BillAmount = item.BillAmount,
                        ExpirationDate = item.ExpirationDate,
                        IsFinalized = item.IsFinalized,
                        ObjectStateTitle = item.ObjectState?.Title,
                        TransactionMode = item.TransactionMode,
                        CreatedDate = item.CreatedDate,
                        Entity = new()
                        {
                            Category = new()
                            {
                                Title = item.Slot.Entity.Category.Title,
                                Description = item.Slot.Entity.Category.Description,
                            },
                            Title = item.Slot.Entity.Title,
                            DaysToCancel = item.Slot.Entity.DaysToCancel,
                        },
                        Slot = new()
                        {
                            StartDate = item.Slot.StartDate,
                            EndDate = item.Slot.EndDate,
                        },

                        Relatives = item
                            .SelectedRelatives.Select(x => new External_SelectedRelativeDto()
                            {
                                FirstName = x.Relative.FirstName,
                                LastName = x.Relative.FamilyName,
                                RelationTitle = x.Relative.Relation.Title,
                            })
                            .ToList(),
                    }
                );
            });

            return new(new(count, request.PageNumber, request.PageSize), result);
        }


        public async Task<External_ReservationDto> GetReservationsOfUserByReservationIdAsync(
            Guid Id
        )
        {
            var currentUser = _systemContext.CurrentUser.GetUserId().Value.ToString();
            var query = await _repositoryManager
                .Reservation.FindByCondition(r => r.UserId == currentUser && r.Id == Id, false)
                .Include(r => r.Slot.Entity.Category)
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative.Relation)
                .Include(x =>
                    x.ReservationStates.OrderByDescending(y => y.CreatedDate).Take(1)
                )
                .ThenInclude(x => x.ObjectState)
                .OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();


            External_ReservationDto result = new()
            {
                Id = query.Id,
                Amount = query.Amount,
                BillAmount = query.BillAmount,
                ExpirationDate = query.ExpirationDate,
                IsFinalized = query.IsFinalized,
                ObjectStateTitle = query.ObjectState?.Title,
                TransactionMode = query.TransactionMode,
                CreatedDate = query.CreatedDate,
                Entity = new()
                {
                    Category = new()
                    {
                        Title = query.Slot.Entity.Category.Title,
                        Description = query.Slot.Entity.Category.Description,
                    },
                    Id = query.Slot.EntityId,
                    Title = query.Slot.Entity.Title,
                    DaysToCancel = query.Slot.Entity.DaysToCancel,
                },
                Slot = new()
                {
                    StartDate = query.Slot.StartDate,
                    EndDate = query.Slot.EndDate,
                },

                Relatives = query
                            .SelectedRelatives.Select(x => new External_SelectedRelativeDto()
                            {
                                FirstName = x.Relative.FirstName,
                                LastName = x.Relative.FamilyName,
                                RelationTitle = x.Relative.Relation.Title,
                            })
                            .ToList(),
            };


            return result;
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

        public async Task CancelReservation(Guid UserId, Guid ReservationId)
        {
            var reservation = await _repositoryManager
                .Reservation.FindByCondition(x => x.Id == ReservationId, false)
                .Include(x => x.Slot.Entity)
                .Include(y => y.ObjectState)
                .Include(o => o.ReservationStates.OrderByDescending(t => t.CreatedDate))
                .ThenInclude(x => x.ObjectState)
                .Include(x => x.TxCoupons)
                .Include(x => x.TxUsers)
                .Include(x => x.TxCredit)
                .FirstOrDefaultAsync();
            var currentState = reservation.ReservationStates.FirstOrDefault().ObjectState;

            if (currentState.Cancellable && currentState.CancelNode.HasValue)
            {
                DateTime startOfSlot = reservation.Slot.StartDate;

                var diff = DateTime.Now.Subtract(startOfSlot);

                if (reservation.Slot.Entity.DaysToCancel >= diff.TotalDays)
                {
                    var cancelNode = await _ObjectStateService.GetStateByCode(
                        currentState.CategoryId,
                        currentState.CancelNode.Value
                    );
                    reservation.ObjectStateId = cancelNode.Id;

                    await _reservationStateService.CancelObject(ReservationId, cancelNode.Id);
                    reservation.ObjectState = null;
                    reservation.ReservationStates = null;
                    reservation.Slot = null;
                    reservation.SelectedRelatives = null;
                    reservation.TxCredit = null;
                    reservation.TxCoupons = null;
                    reservation.TxUsers = null;

                    _repositoryManager.Reservation.Update(reservation);

                    await _couponTxService.AddTransaction(
                        new()
                        {
                            //TODO: تغییر یافته برای بی اثر شدن محاسبات
                            //Amount = ReservationModel.Amount - ReservationModel.BillAmount,
                            Amount = -reservation
                                .TxCoupons.OrderBy(x => x.CreatedDate)
                                .FirstOrDefault()
                                .Amount,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            PeriodId = _systemContext.Period.Id,
                            ReservationId = reservation.Id,
                            UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            Description =
                                DateTime.Now.ToString("yyyy.MM.dd") + "  بابت لغو رزرو  در تاریخ ",
                        }
                    );

                    await _userTxService.AddTransaction(
                        new()
                        {
                            Amount = -reservation
                                .TxUsers.OrderBy(x => x.CreatedDate)
                                .FirstOrDefault()
                                .Amount,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            PeriodId = _systemContext.Period.Id,
                            ReservationId = reservation.Id,
                            UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            Description =
                                DateTime.Now.ToString("yyyy.MM.dd") + "  بابت لغو رزرو  در تاریخ ",
                        }
                    );

                    await _creditTxService.AddTransaction(
                        new Internal_TransactionDto()
                        {
                            Amount = -reservation
                                .TxCredit.OrderBy(x => x.CreatedDate)
                                .FirstOrDefault()
                                .Amount,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            PeriodId = _systemContext.Period.Id,
                            ReservationId = reservation.Id,
                            UserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                            Description =
                                DateTime.Now.ToString("yyyy.MM.dd") + "  بابت لغو رزرو  در تاریخ ",
                        }
                    );
                    _repositoryManager.Save();
                }
            }
        }
    }
}
