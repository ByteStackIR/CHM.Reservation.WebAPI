using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Entities.DataTransferObjects.Models
{
    public class ObjectStateDto
    {
        public int Code { get; set; }

        public int? NextNode { get; set; }
        public int? PreviousNode { get; set; }

        public int? CancelNode { get; set; }

        public string Title { get; set; }

        public Guid CategoryId { get; set; }

        /// <summary>
        /// کاربر ایجاد کننده میتواند کنسل کند
        /// </summary>
        public bool Cancellable { get; set; }

        /// <summary>
        /// اجازه حرکت رو به جلو
        /// </summary>
        public bool ToForward { get; set; }

        /// <summary>
        /// اجازه حرکت رو به عقب
        /// </summary>
        public bool ToBackward { get; set; }

        public string RoleId { get; set; }

        /// <summary>
        /// نقطه پایانی هست یا خیر
        /// </summary>
        public bool IsFinalNode { get; set; }
        public bool IsStartNode { get; set; }
    }
}
