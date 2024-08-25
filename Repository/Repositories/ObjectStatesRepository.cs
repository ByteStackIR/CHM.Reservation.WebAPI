using Contracts.IRepository;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ObjectStatesRepository : RepositoryBase<ObjectStates> , IObjectStatesRepository
    {
        public ObjectStatesRepository(DBContextProvider context) : base(context)
        {
        
        }
    }
}
