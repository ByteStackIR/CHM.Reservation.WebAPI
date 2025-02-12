using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IRelationRepository : IRepositoryBase<Relation>
    {

       Task<Relation> GetFullById(Guid RelationId);
    }
}
