using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IPeriodService
    {
        bool AddPeriod(PeriodDto dto);
        Task<PeriodDto> UpdatePeriod(PeriodDto dto);
    }
}
