using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;

namespace Services.Services;

public class RelativesService : ServiceBase, IRelativesService
{
    public RelativesService(IMapper mapper,IRepositoryManager repoManger) : base(repoManger, mapper)
    {

    }
    
}