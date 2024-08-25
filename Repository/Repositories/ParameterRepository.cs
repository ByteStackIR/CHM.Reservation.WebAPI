using Contracts.IMarker;
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
    public class ParameterRepository : RepositoryBase<Parameter> , IParameterRepository, IScopeMarker
    {
        public ParameterRepository(DBContextProvider context) : base(context)
        {

        }
    }
}
