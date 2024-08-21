using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Features.RequestParameters
{
    public class RequestParameters
    {
        public int MinAge {  get; set; }
        public int MaxAge {  get; set; }

        public bool AgeRangeValidator() => MinAge <= MaxAge;

        public string? Fields { get; set; }
        


    }
}
