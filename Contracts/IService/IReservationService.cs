using Entities.DataTransferObjects;
using Entities.DataTransferObjects.External;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.Enum;
using Features.CustomRequest;
using Features.RequestFeatures;


namespace Contracts.IService
{
    public interface IReservationService
    {

        Task<Internal_ReservationDto> InitReservation(ReservationCreationDto dto);
        Task<Internal_ReservationDto> CreateTemporaryReservation(Internal_ReservationDto dto);
        Task CancelTemporaryReservation(Guid ReservationId);


        Task<Internal_ShareDto> CalculateShare(RelativeDto Relative, EntityDto Entity);

        Task<List<Internal_ShareDto>> CalculateShares(
            List<RelativeDto> Relatives,
            EntityDto Entity,
            SlotDto slot,
            TransactionMode mode
        );
        Task<External_TempReservationDto> AddReservation(ReservationCreationDto dto);
        Task<bool> FinalizeReservation(FinalizeReservationDto dto);
        Task<External_TempReservationDto> GetTemporaryReservation(Guid UserId);

        Task<PagedData<List<External_ReservationDto>>> GetPagedAllReservationsAsync(ReservationRequest request);
        //cartable services
        Task<PagedData<List<External_ReservationDto>>> GetPagedReservationsOfUserAsync(ReservationRequest_User request);
        Task<External_ReservationDto> GetReservationsOfUserByReservationIdAsync(Guid Id);
        Task<PagedData<List<ReservationDto>>> GetPagedReservationsOfHotelAsync(ReservationRequest_Hotel request);
        Task<PagedData<List<ReservationDto>>> GetPagedReservationOfExecutiveAsync(ReservationRequest_Executive request);
        Task CancelReservation(Guid UserId, Guid ReservationId);
    }
}
