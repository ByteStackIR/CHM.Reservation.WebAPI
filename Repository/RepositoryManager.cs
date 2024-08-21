using Contracts.IRepository;
using Contracts.IRepository;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private DBContextProvider _context;


        private readonly Lazy<ITransactionRepository> _ITransactionRepository;

        public RepositoryManager(DBContextProvider Context)
        {
            _context = Context;



     _ITransactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(_context));

        }




        public ITransactionRepository ITransactionRepository => _ITransactionRepository.Value;


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

