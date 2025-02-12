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
    public class RelativesRepository : RepositoryBase<Relatives> , IRelativesRepository, IScopeMarker
    {
        public RelativesRepository(DBContextProvider context) : base(context)
        {

        }

        public async Task<IEnumerable<Relatives>> GetConfirmedRelatives(Guid UserId)
        {
            return await _dbSet.Where(
                    x =>
                        x.UserId == UserId.ToString()
                        && x.IsChecked
                        && x.IsConfirmed
                        && !x.IsDeleted
                    
                )
                .Include(x => x.Relation)
                .ToListAsync();

        }

        public async Task<IEnumerable<Relatives>> GetRelatives(List<Guid> Ids)
        {
            return await _dbSet.Where(x => Ids.Contains(x.Id) && x.IsChecked && x.IsConfirmed && !x.IsDeleted).ToListAsync();
        }

    }
}
