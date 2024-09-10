using Entities.DataTransferObjects.Models;
using Entities.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface ISlotService
    {
        Task<PagedData<List<SlotDto>>> GetPagedAvailableSlotsAsync(SlotRequest request);
        Task<SlotDto> GetOccupancyBySlotId(Guid Id);
    }
}
