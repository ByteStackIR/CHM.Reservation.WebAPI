using Contracts.IDapperRepository;
using Contracts.IRepository;
using Dapper;
using Dapper.DapperReporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DapperReporsitory
{
    public class ConcertDapperRepository : BaseDapperRepository, IConcertDapperRepository
    {
        private readonly DapperContext _context;
        public ConcertDapperRepository(DapperContext context) => _context = context;
    }
}
