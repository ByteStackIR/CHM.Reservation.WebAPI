using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Models
{
    public class AttachmentDto
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public string FileName { get; set; }
        public string FileCategory { get; set; }
        public string FileType { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
