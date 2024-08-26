namespace Services.Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Contracts.IService;
    using Entities.DataTransferObjects;
    using Entities.Models;
    using LoggerService;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="PeriodService" />
    /// </summary>
    public class PeriodService : ServiceBase, IPeriodService, IScopeMarker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodService"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <param name="repoManger">The repoManger<see cref="IRepositoryManager"/></param>
        /// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
        /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
        public PeriodService(
            IMapper mapper,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
            ILoggerManager logger
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
        }

        /// <summary>
        /// The AddPeriod
        /// </summary>
        /// <param name="dto">The dto<see cref="PeriodDto"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool AddPeriod(PeriodDto dto)
        {
            try
            {
                dto.Id = Guid.NewGuid();
                //var periodModel = _mapper.Map<Period>(dto);
                Period periodModel = new Period
                {
                    Id = dto.Id,
                    StartDate = dto.StartDate,
                    EndDate = dto.EndDate,
                    Stipend = dto.Stipend,
                    CreatedDate = DateTime.Now,
                };

                _repositoryManager.Period.Create(periodModel);
                _repositoryManager.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// The UpdatePeriod
        /// </summary>
        /// <param name="dto">The dto<see cref="PeriodDto"/></param>
        /// <returns>The <see cref="Task{PeriodDto}"/></returns>
        public async Task<PeriodDto> UpdatePeriod(PeriodDto dto)
        {
            try
            {
                Period? periodModel = await _repositoryManager.Period.GetByIdAsync(dto.Id);
                if (periodModel is not null)
                {
                    periodModel.StartDate = dto.StartDate;
                    periodModel.EndDate = dto.EndDate;
                    periodModel.Stipend = dto.Stipend;
                    _repositoryManager.Period.Update(periodModel);
                    _repositoryManager.Save();
                    return dto;
                }
                else
                {
                    throw new Exception($"Period With Id of {dto.Id} Not Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An Error Occured While Updating Period With Id of {dto.Id}");
            }
        }
    }
}
