using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IReservationRepository : IRepositoryBase<Reservation>
    {

        Task<Reservation> GetTemporaryReservation(Guid UserId);

        Task<PaginationDto<Reservation>> GetAllReservationWithoutConsideringStates(ReservationRequest request);
        Task<PaginationDto<Reservation>> GetPagedReservationsOfUserAsync(RequestFeatures request,Guid UserId);
        Task<PaginationDto<Reservation>> GetPagedReservationsOfEntityAsync(ReservationRequest_Hotel request);
        Task<PaginationDto<Reservation>> GetPagedReservationOfExecutiveAsync(RequestFeatures request, Expression<Func<Reservation, bool>> expression);


        Task<Reservation> GetReservationsOfUserByIdAsync(Guid UserId,Guid Reservation);
        Task<Reservation> GetTempoReservationForCancel( Guid ReservationId);
        Task<Reservation> GetReservationForCancel(Guid ReservationId);
        Task<int> GetOccupancyBySlotId(Guid SlotId);



    }
}
