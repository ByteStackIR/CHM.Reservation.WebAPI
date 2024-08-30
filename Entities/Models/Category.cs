using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Category : ModelBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Parameter> Parameters { get; set; }
        public ICollection<Entity> Entities { get; set; }
    }
}
