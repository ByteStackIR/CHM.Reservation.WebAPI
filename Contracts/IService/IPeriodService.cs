using Entities.DataTransferObjects.Models;
using Entities.Models;
using Features.CustomRequest;
using Features.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IPeriodService
    {
        Task<PagedData<List<PeriodDto>>> GetPagnationData(PeriodTableRequest request);
        Task<PeriodDto> GetById(Guid periodId);
        bool AddPeriod(PeriodDto dto);
        Task<PeriodDto> UpdatePeriod(PeriodDto dto);
        Task<PeriodDto> DeletePeriod(Guid Id);
    }
}
