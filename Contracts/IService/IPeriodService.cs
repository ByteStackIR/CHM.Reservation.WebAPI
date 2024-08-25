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
        public bool AddPeriod(PeriodDto dto);
    }
}
