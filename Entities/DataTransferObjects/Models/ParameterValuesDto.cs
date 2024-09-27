using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class ParameterValuesDto
    {
        public Guid? Id { get; set; }
        public Guid ParameterId { get; set; }
        public Guid EntityId { get; set; }
        public int DisplayOrder { get; set; }

        public string Value { get; set; } = string.Empty;
    }
}
