namespace Services.Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IRepository;
    using Contracts.IService;
    using LoggerService;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Defines the <see cref="ServiceBase" />
    /// </summary>
    public class ServiceBase : IService
    {
        /// <summary>
        /// Defines the _repositoryManager
        /// </summary>
        protected readonly IRepositoryManager _repositoryManager;

        /// <summary>
        /// Defines the _mapper
        /// </summary>
        protected readonly IMapper _mapper;

        /// <summary>
        /// Defines the _systemContext
        /// </summary>
        protected readonly ISystemContext _systemContext;

        /// <summary>
        /// Defines the _logger
        /// </summary>
        protected readonly ILoggerManager _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBase"/> class.
        /// </summary>
        /// <param name="repositoryManager">The repositoryManager<see cref="IRepositoryManager"/></param>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <param name="httpAccessor">The httpAccessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
        /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
        public ServiceBase(
            IRepositoryManager repositoryManager,
            IMapper mapper,
            IHttpContextAccessor httpAccessor,
            ISystemContext systemContext,
            ILoggerManager logger
        )
        {
            _systemContext = systemContext;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _systemContext
                .InitializeSystemContext(_repositoryManager, httpAccessor, _mapper)
                .Wait();
            _logger = logger;
        }
    }
}
