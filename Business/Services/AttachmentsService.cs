using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IDataShaper;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.Enum;
using Entities.Models;
using Features.RequestFeatures;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Services.Services
{
    public class AttachmentsService : ServiceBase, IAttachmentsService,IScopeMarker
    {
        ILoggerManager _logger;
        private readonly IRepositoryManager _repositoryManager;

        public AttachmentsService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) {

            _repositoryManager = repoManger;
        }

        public async Task<string> AddToStore(
            string fileName,
            string FileCategory,
            string FileType,
            int DisplayOrder,
            Guid ObjectId
        )
        {
            Guid RowId = Guid.NewGuid();

            _repositoryManager.AttachmentsRepository.Create(
                new()
                {
                    Id = RowId,
                    CreatedDate = DateTime.Now,
                    FileCategory = FileCategory,
                    FileName = fileName,
                    FileType = FileType,
                    ObjectId = ObjectId,
                    DisplayOrder = DisplayOrder,
                }
            );
            _repositoryManager.Save();
            return RowId.ToString();
        }

        public async Task UpdateStore(Guid Id, int DisplayOrder, Guid ObjectId)
        {
            var model = await _repositoryManager.AttachmentsRepository.GetByIdAsync(Id);

            model.DisplayOrder = DisplayOrder;
            _repositoryManager.AttachmentsRepository.Update(model);
            _repositoryManager.Save();
            return;
        }

        public async Task<Attachments> GetFromStore(Guid AttachId)
        {
            return await _repositoryManager
                .AttachmentsRepository.FirstOrDefaultAsync(x => x.Id == AttachId)
               ;
        }

        public async Task RemoveFromStore(Guid AttachId)
        {
            _repositoryManager.AttachmentsRepository.Delete(
                await _repositoryManager
                    .AttachmentsRepository.FirstOrDefaultAsync(x => x.Id == AttachId)
                   
            );
        }
    }
}
