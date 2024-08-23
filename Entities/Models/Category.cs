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
        public string Title { get; set; } = string.Empty;
        public ICollection<Parameter> Parameters { get; set; } = new List<Parameter>();
        public ICollection<Entity> Entities { get; set; } = new List<Entity>();
    }
}
