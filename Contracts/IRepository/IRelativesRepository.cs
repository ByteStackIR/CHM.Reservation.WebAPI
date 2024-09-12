using Entities.Models;
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



    }
}
