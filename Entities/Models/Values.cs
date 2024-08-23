using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Values : ModelBase
    {
        public Guid ParameterId { get; set; }
        public string Value { get; set; } = string.Empty;
        
        public Parameter Parameter { get; set; } = new Parameter();
    }
}
