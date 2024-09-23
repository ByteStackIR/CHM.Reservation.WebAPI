using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IMarker;
using Contracts.IRepository;
using Entities;
using Entities.Models;

namespace Repositories.Repositories
{
    public class DefinitionsRepository
        : RepositoryBase<Definitions>,
            IDefinitionsRepository,
            IScopeMarker
    {
        public DefinitionsRepository(DBContextProvider context)
            : base(context) { }
    }
}
