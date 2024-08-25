using AutoMapper;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PeriodService : ServiceBase , IPeriodService , IScopeMarker
    {
        private readonly ILoggerManager _logger;
        public PeriodService(IRepositoryManager repositoryManager, ILoggerManager logger ,IMapper mapper) : base(repositoryManager,mapper)
        {
            _logger = logger;
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
        
    }
}
