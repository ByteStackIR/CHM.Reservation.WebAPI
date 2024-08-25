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
    public class PersonsRepository : RepositoryBase<Persons> , IPersonsRepository
    {
        public PersonsRepository(DBContextProvider context) : base(context)
        {

        }
    }
}
