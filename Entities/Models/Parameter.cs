using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Parameter : ModelBase
    {
        public Guid CategoryId { get; set; } 
        public string Title { get; set; } = string.Empty;

        public Category Category { get; set; } = new Category();
        public ICollection<Values> Values { get; set; } = new List<Values>();

    }
}
