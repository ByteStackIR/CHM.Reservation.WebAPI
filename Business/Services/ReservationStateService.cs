using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IRepository;
using Contracts.IService;
using Entities.IdentityExtensions;
using LoggerService;
using Microsoft.AspNetCore.Http;

namespace Services.Services
{
    public class ReservationStateService : ServiceBase, IReservationStateService
    {
        private IObjectStateService _objectStateService;

        public ReservationStateService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
            IObjectStateService objectStateService
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _objectStateService = objectStateService;
        }

        public async Task<bool> GoToNextStep(Guid ReservationId)
        {
            var currentState = await _repositoryManager.ReservationStates.GetByIdAsync(
                ReservationId
            );
            var currentObjectState = await _objectStateService.GetStateById(
                currentState.ObjectStateId
            );
            if (currentObjectState.ToForward)
            {
                var NextobjectState = await _objectStateService.GetNextStateByState(
                    currentObjectState
                );
                if (NextobjectState.IsFinalNode)
                {
                    currentState.IsDone = true;
                    currentState.ActorUserId = _systemContext.CurrentUser.GetUserId().ToString();
                    _repositoryManager.ReservationStates.Update(currentState);

                    _repositoryManager.ReservationStates.Create(
                        new()
                        {
                            ActorUserId = currentState.ActorUserId,
                            IsDone = true,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            IsCancelled = false,
                            ReservationId = ReservationId,
                            ToForward = true,
                            ObjectStateId = NextobjectState.Id,
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                        }
                    );
                }
                else
                {
                    currentState.IsDone = true;
                    currentState.ActorUserId = _systemContext.CurrentUser.GetUserId().ToString();
                    _repositoryManager.ReservationStates.Update(currentState);

                    _repositoryManager.ReservationStates.Create(
                        new()
                        {
                            IsDone = false,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            IsCancelled = false,
                            ReservationId = ReservationId,
                            ToForward = true,
                            ObjectStateId = NextobjectState.Id,
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                        }
                    );
                }
                _repositoryManager.Save();
                return true;
            }
            return false;
        }

        public async Task<bool> GoToPreviousStep(Guid ReservationId)
        {
            var currentState = await _repositoryManager.ReservationStates.GetByIdAsync(
                ReservationId
            );
            var currentObjectState = await _objectStateService.GetStateById(
                currentState.ObjectStateId
            );
            if (currentObjectState.ToBackward)
            {
                var PreviousobjectState = await _objectStateService.GetPreviousStateByState(
                    currentObjectState
                );
                if (PreviousobjectState.IsFinalNode)
                {
                    currentState.IsDone = true;
                    currentState.ActorUserId = _systemContext.CurrentUser.GetUserId().ToString();
                    _repositoryManager.ReservationStates.Update(currentState);

                    _repositoryManager.ReservationStates.Create(
                        new()
                        {
                            ActorUserId = currentState.ActorUserId,
                            IsDone = true,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            IsCancelled = false,
                            ReservationId = ReservationId,
                            ToForward = false,
                            ObjectStateId = PreviousobjectState.Id,
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                        }
                    );
                }
                else
                {
                    currentState.IsDone = true;
                    currentState.ActorUserId = _systemContext.CurrentUser.GetUserId().ToString();
                    _repositoryManager.ReservationStates.Update(currentState);

                    _repositoryManager.ReservationStates.Create(
                        new()
                        {
                            IsDone = false,
                            CreatedDate = DateTime.Now,
                            Id = Guid.NewGuid(),
                            IsCancelled = false,
                            ReservationId = ReservationId,
                            ToForward = false,
                            ObjectStateId = PreviousobjectState.Id,
                            CreatorUserId = _systemContext.CurrentUser.GetUserId().Value.ToString(),
                        }
                    );
                }
                _repositoryManager.Save();
                return true;
            }
            return false;
        }

        //private async Task<bool> SatisfyTheRequirements(ReservationStatusDto dto)
        //{

        //}
    }
}
