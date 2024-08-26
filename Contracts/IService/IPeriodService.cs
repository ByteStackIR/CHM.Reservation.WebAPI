using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IPeriodService
    {
        Task<PeriodDto> GetById(Guid periodId);
        bool AddPeriod(PeriodDto dto);
        Task<PeriodDto> UpdatePeriod(PeriodDto dto);
        Task<PeriodDto> DeletePeriod(Guid Id);
    }
}
