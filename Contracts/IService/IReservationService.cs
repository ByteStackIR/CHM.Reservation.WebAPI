using Entities.DataTransferObjects;
using Entities.DataTransferObjects.External;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Features.CustomRequest;
using Features.RequestFeatures;


namespace Contracts.IService
{
    public interface IReservationService
    {

        Task<Internal_ReservationDto> InitReservation(ReservationCreationDto dto);
        Task<Internal_ReservationDto> CreateTemporaryReservation(Internal_ReservationDto dto);
        Task<Internal_ShareDto> CalculateShare(RelativeDto Relative, EntityDto Entity);

        Task<List<Internal_ShareDto>> CalculateShares(
            List<RelativeDto> Relatives,
            EntityDto Entity
        );
        Task<External_TempReservationDto> AddReservation(ReservationCreationDto dto);
        Task<bool> FinalizeReservation(Guid Id);
        Task<External_TempReservationDto> GetTemporaryReservation(Guid UserId);
        //cartable services
        Task<PagedData<List<ReservationDto>>> GetPagedReservationsOfUserAsync(ReservationRequest_User request);
        Task<PagedData<List<ReservationDto>>> GetPagedReservationsOfHotelAsync(ReservationRequest_Hotel request);
        Task<PagedData<List<ReservationDto>>> GetPagedReservationOfExecutiveAsync(ReservationRequest_Executive request);
    }
}
