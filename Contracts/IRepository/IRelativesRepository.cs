using Entities.DataTransferObjects.Pagination;
using Entities.Models;
using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IRelativesRepository : IRepositoryBase<Relatives>
    {

       Task<IEnumerable<Relatives>> GetRelatives(List<Guid> Ids);
        //Task<IEnumerable<Relatives>> GetRelatives(List<Guid> Ids);
        Task<IEnumerable<Relatives>> GetConfirmedRelatives(Guid UserId);




    }
}
