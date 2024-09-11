using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IRepository;
using Entities;
using Entities.Models;

namespace Repositories.Repositories
{
    public class AttachmentsRepository : RepositoryBase<Attachments>, IAttachmentsRepository
    {
        public AttachmentsRepository(DBContextProvider dBContextProvider)
            : base(dBContextProvider) { }
    }
}
