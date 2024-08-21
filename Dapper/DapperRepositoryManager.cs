using Contracts.IDapperRepository;
using Dapper.DapperReporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    public class DapperRepositoryManager 
    {
        private readonly DapperContext _dapperContext;
        private readonly Lazy<IConcertDapperRepository> _IConcertDapperRepository;

        public DapperRepositoryManager(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;

            _IConcertDapperRepository = new Lazy<IConcertDapperRepository>(() => new ConcertDapperRepository(_dapperContext));


        }



        public IConcertDapperRepository ConcertDapperRepository => _IConcertDapperRepository.Value;

    }
}
