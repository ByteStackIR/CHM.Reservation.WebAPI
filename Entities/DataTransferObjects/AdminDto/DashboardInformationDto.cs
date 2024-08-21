using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.AdminDto
{
    public class DashboardInformationDto
    {
        public DashboardCardItemDto WeekIncome { get; set; }
        public DashboardCardItemDto DayIncome { get; set; }
        public DashboardCardItemDto DailySale { get; set; }
    }
}
