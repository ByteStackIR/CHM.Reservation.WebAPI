using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
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

        public async Task<PeriodDto> GetById(Guid periodId)
        {
            try
            {
                var periodModel = await _repositoryManager.Period.GetByIdAsync(periodId);
                if (periodModel is not null && periodModel.IsDeleted is false)
                {
                    var periodDto = _mapper.Map<PeriodDto>(periodModel);
                    return periodDto;
                }
                else
                {
                    throw new KeyNotFoundException($"Period with ID {periodId} was not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
                    IsDeleted = false,
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
                if (periodModel is not null && periodModel.IsDeleted is false)
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

        public async Task<PeriodDto> DeletePeriod(Guid Id)
        {
            try
            {
                Period? periodModel = await _repositoryManager.Period.GetByIdAsync(Id);
                if (periodModel is not null)
                {
                    periodModel.IsDeleted = true;
                    _repositoryManager.Period.Update(periodModel);
                    _repositoryManager.Save();
                    return new PeriodDto();
                }
                else
                {
                    throw new Exception($"Period With Id of {Id} Not Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An Error Occured While Updating Period With Id of {Id}");
            }
        }
    }

