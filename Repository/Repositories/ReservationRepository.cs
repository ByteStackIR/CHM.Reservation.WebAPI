using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.Constant;
using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Repositories.Repositories
{
    public class ReservationRepository : RepositoryBase<Reservation> , IReservationRepository, IScopeMarker
    {
        public ReservationRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<PaginationDto<Reservation>> GetAllReservationWithoutConsideringStates(ReservationRequest request)
        {
             

                var query =  _dbSet.Where(r => r.Slot.EntityId == request.EntityId)
                .Include(r => r.Slot.Entity.Category)
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative.Relation)
                .Include(x =>
                    x.ReservationStates.OrderByDescending(y => y.CreatedDate).Take(1)
                )
                .ThenInclude(x => x.ObjectState)
                .OrderByDescending(x => x.CreatedDate);


            return new()
            {
                Data = await query.GetPage(request).ToListAsync(),
                TotalCount = query.Count()
            };

        }

        public async Task<PaginationDto<Reservation>> GetPagedReservationsOfUserAsync(RequestFeatures request, Guid UserId)
        {
            var query = _dbSet.Where(r => r.UserId.ToLower() == UserId.ToString().ToLower())
                .Include(r => r.Slot.Entity.Category)
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative.Relation)
                .Include(x =>
                    x.ReservationStates.OrderByDescending(y => y.CreatedDate).Take(1)
                )
                .ThenInclude(x => x.ObjectState)
                .OrderByDescending(x => x.CreatedDate);


            return new()
            {
                Data = await query.GetPage(request).ToListAsync(),
                TotalCount = query.Count()
            };
        }

        public async Task<PaginationDto<Reservation>> GetPagedReservationsOfEntityAsync(ReservationRequest_Hotel request)
        {
            var query = _dbSet.Where(r => r.Slot.EntityId == request.EntityId)
                .Include(r => r.Slot)
                .Include(r => r.ReservationStates);

            return new()
            {
                Data = await query.GetPage(request).ToListAsync(),
                TotalCount = query.Count()
            };
        }

        public async Task<Reservation> GetReservationsOfUserByIdAsync(Guid UserId, Guid ReservationId)
        {
            return await _dbSet.Where(r => r.UserId.ToLower() == UserId.ToString().ToLower() && r.Id == ReservationId)
                   .Include(r => r.Slot.Entity.Category)
                   .Include(x => x.SelectedRelatives)
                   .ThenInclude(x => x.Relative.Relation)
                   .Include(x =>
                       x.ReservationStates.OrderByDescending(y => y.CreatedDate).Take(1)
                   )
                   .ThenInclude(x => x.ObjectState)
                   .OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();


        }

        public async Task<Reservation> GetTemporaryReservation(Guid UserId)
        {
           return await _dbSet.Where(
                    x =>
                        x.UserId == UserId.ToString()
                        && x.IsFinalized == false
                        && x.ExpirationDate > DateTime.Now
               
                )
                .Include(x => x.SelectedRelatives)
                .ThenInclude(x => x.Relative)
                .Include(x => x.Slot.Entity)
                .FirstOrDefaultAsync();
        }

        public async Task<PaginationDto<Reservation>> GetPagedReservationOfExecutiveAsync(RequestFeatures request, System.Linq.Expressions.Expression<Func<Reservation, bool>> expression)
        {
            
            var query = _dbSet.Where(expression).Include(r => r.Slot);


            return new()
            {
                Data = await query.GetPage(request).ToListAsync(),
                TotalCount = query.Count()
            };
        }

        public async Task<Reservation> GetTempoReservationForCancel(Guid ReservationId)
        {
            return await _dbSet.Where(x => x.Id == ReservationId)
                .Include(x => x.SelectedRelatives)
                .FirstOrDefaultAsync();
        }

        public async Task<Reservation> GetReservationForCancel(Guid ReservationId)
        {
            return await _dbSet.Where(x => x.Id == ReservationId)
                .Include(x => x.Slot.Entity)
                .Include(y => y.ObjectState)
                .Include(o => o.ReservationStates.OrderByDescending(t => t.CreatedDate))
                .ThenInclude(x => x.ObjectState)
                .Include(x => x.TxCoupons)
                .Include(x => x.TxUsers)
                .Include(x => x.TxCredit)
                .FirstOrDefaultAsync();
        }


       public async Task<int> GetOccupancyBySlotId(Guid SlotId)
        {
            //TODO: condition to be added!!! filter only on those that are final

            return await _dbSet.Where(
                        y =>
                            y.SlotId == SlotId && ((
                                y.IsFinalized
                                && (
                                    y.ObjectStateId
                                        != Guid.Parse(CancelStateConstant.HotelCancelState)
                                    && y.ObjectStateId
                                        != Guid.Parse(CancelStateConstant.TourCancelState)
                                )
                            ) || (y.IsFinalized == false && y.ExpirationDate >= DateTime.Now))

                    )
                    .Include(x => x.SelectedRelatives)
              .Select(x => x.SelectedRelatives.Count()).SumAsync();
        }
    }
}
