using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Entities.QueryExtensions;
using Features.CustomRequest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class SlotRepository : RepositoryBase<Slot> , ISlotRepository, IScopeMarker
    {
        public SlotRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<PaginationDto<Slot>> GetPagedSlotByEntityId(SlotRequest request)
        {
            var query =  _dbSet.Where(x => x.EntityId == request.EntityId);
            return new()
            {
                Data = await query.GetPage(request).ToListAsync(),
                TotalCount = query.Count()
            };
        }
    }
}
