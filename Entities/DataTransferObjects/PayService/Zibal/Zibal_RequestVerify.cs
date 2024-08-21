using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PayService.Zibal
{
    public class Zibal_RequestVerify
    {
        public string merchant { get; set; }
        public long trackId { get; set; }

    }
}
