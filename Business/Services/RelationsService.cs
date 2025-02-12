using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects.Models;
using Entities.Enum;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    public class RelationsService : ServiceBase, IRelationsService, IScopeMarker
    {
        public RelationsService(
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger) { }

        public async Task<List<RelationDto>> GetRelations()
        {
            var res = await _repositoryManager.Relation.FindAll(x=>x.ParentId!=null);

            // res.ForEach(r => { r.Maximum = null; });

            return _mapper.Map<List<RelationDto>>(res);
        }

        public async Task<RelationDto> GetByType(RelationType type)
        {
            var model = await _repositoryManager
                .Relation.FirstOrDefaultAsync(x => x.Type == type);

            return _mapper.Map<RelationDto>(model);
        }

        /// <summary>
        /// بررسی نیاز به تاییدیه دارید یا ندراد
        /// </summary>
        /// <param name="RelationId"></param>
        /// <returns></returns>
        public async Task<bool> NeedConfirmation(Guid RelationId)
        {
            var Rel = await _repositoryManager
                .Relation.GetFullById(RelationId);

            if (Rel is null)
                throw new Exception("Invalid relation!");

            return Rel.Parent.Type == Entities.Enum.RelationType.DEPENDENTS;
        }

        /// <summary>
        /// تعداد افراد مجاز برای هر نسبت
        /// </summary>
        /// <param name="RelationId"></param>
        /// <returns></returns>
        public async Task<bool> CheckMaximumLimit(Guid RelationId, Guid UserId)
        {
            var Rel = await _repositoryManager
                .Relation.FirstOrDefaultAsync(x => x.Id == RelationId && x.Maximum != null);

            if (Rel is null)
                return true;
            else
            {
                int count = (await _repositoryManager
                    .Relatives.FindAll(
                        x =>
                            x.RelationId == RelationId
                            && x.IsDeleted != true
                            && x.UserId == UserId.ToString()
                            && (x.IsChecked && x.IsConfirmed || !x.IsChecked)
                    ))
                    .Count();

                if (Rel.Maximum <= count)
                    return false;

                return true;
            }
        }

        public async Task<bool> CanBeDeleted(Guid RelationId)
        {
            var Rel = await _repositoryManager
                .Relation.FirstOrDefaultAsync(x => x.Id == RelationId);

            return Rel.Type != Entities.Enum.RelationType.SELF;
        }
    }
}
