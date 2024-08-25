using Contracts.IRepository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public abstract class Tx_BaseRepository<T> : RepositoryBase<T> , ITx_BaseRepository<T> where T : class
    {
        public Tx_BaseRepository(DBContextProvider context) : base(context)
        {

        }
    }
}
