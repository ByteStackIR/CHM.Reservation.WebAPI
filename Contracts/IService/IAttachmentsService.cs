using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IAttachmentsService : IService
    {
        Task<string> AddToStore(string fileName, string Type,string FileType, Guid ObjectId);
        Task<Attachments> GetFromStore(Guid AttachId);
        Task RemoveFromStore(Guid AttachId);
    }
}
