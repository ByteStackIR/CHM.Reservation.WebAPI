using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Attachments : ModelBase
    {
        public Guid ObjectId { get; set; }
        public string FileName { get; set; }
        public string FileCategory { get; set; }
        public string FileType { get; set; }

       
    }
}
