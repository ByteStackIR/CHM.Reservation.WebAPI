using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ServiceBase : IService
    {
        protected readonly IRepositoryManager _repositoryManager;
        protected readonly IMapper _mapper;
        public ServiceBase(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
    }
}
