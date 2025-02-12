using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RelationRepository : RepositoryBase<Relation> , IRelationRepository, IScopeMarker
    {
        public RelationRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<Relation> GetFullById(Guid RelationId)
        {
            return await _dbSet.Where(x => x.Id == RelationId && x.ParentId != null)
                .Include(x => x.Parent)
                .FirstOrDefaultAsync();
        }
    }
}
