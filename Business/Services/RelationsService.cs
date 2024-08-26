using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class RelationsService : ServiceBase, IRelationsService, IScopeMarker
    {
        public RelationsService(IMapper mapper,
      ILoggerManager logger,
      IRepositoryManager repoManger,
      IHttpContextAccessor httpContextAccessor,
      ISystemContext systemContext) :
      base(repoManger,
          mapper,
          httpContextAccessor,
          systemContext,
          logger)
        {

        }


        /// <summary>
        /// بررسی نیاز به تاییدیه دارید یا ندراد
        /// </summary>
        /// <param name="RelationId"></param>
        /// <returns></returns>
        public async Task<bool> NeedConfirmation(Guid RelationId)
        {
            var Rel = await _repositoryManager.Relation.FindByCondition(x => x.Id == RelationId && x.ParentId != null, false)
                .Include(x=>x.Parent)
                .FirstOrDefaultAsync();

            if (Rel is null)
                throw new Exception("Invalid relation!");


            return Rel.Parent.Type == Entities.Enum.RelationType.DEPENDENTS;

        }
    }
}
