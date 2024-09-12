using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Internal;


namespace Contracts.IService
{
    public interface IReservationService
    {

        Task<Internal_ReservationDto> InitReservation(ReservationCreationDto dto);
    }
}
