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
    public class Tx_UserRepository : Tx_BaseRepository<Tx_User> , ITx_UserRepository
    {
        public Tx_UserRepository(DBContextProvider context) : base(context)
        {

        }
    }
}
