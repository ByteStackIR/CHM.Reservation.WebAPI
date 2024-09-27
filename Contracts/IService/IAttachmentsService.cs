using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Contracts.IService
{
    public interface IAttachmentsService : IService
    {
        Task<string> AddToStore(
            string fileName,
            string FileCategory,
            string FileType,
            int DisplayOrder,
            Guid ObjectId
        );
        Task UpdateStore(Guid Id, int DisplayOrder, Guid ObjectId);
        Task<Attachments> GetFromStore(Guid AttachId);
        Task RemoveFromStore(Guid AttachId);
    }
}
