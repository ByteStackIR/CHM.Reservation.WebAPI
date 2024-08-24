using Entities;
using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        IIncludableQueryable<T, TProperty> GetByWithIncludes<TProperty>(Expression<Func<T, bool>> expression, Expression<Func<T, TProperty>> include);
       
        void SaveChanges();
        IIncludableQueryable<T, TProperty> GetWithByAndInclude<TOrderBy, TProperty>(Expression<Func<T, bool>> expression, Expression<Func<T, TOrderBy>> order, Expression<Func<T, TProperty>> include, bool isASC);
        IQueryable<T> GetWithBy<TOrderBy>(Expression<Func<T, bool>> expression, Expression<Func<T, TOrderBy>> order,bool isASC);


    }

}
