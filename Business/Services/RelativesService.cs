using AutoMapper;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;

namespace Services.Services;

public class RelativesService : ServiceBase, IRelativesService , IScopeMarker
{
    public RelativesService(IMapper mapper,IRepositoryManager repoManger) : base(repoManger, mapper)
    {

    }
 
    
    


}