using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Features.CustomRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface ISlotRepository : IRepositoryBase<Slot>
    {


        Task<PaginationDto<Slot>> GetPagedSlotByEntityId(SlotRequest request);



       
    }
}
