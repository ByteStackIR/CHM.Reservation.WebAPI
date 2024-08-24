using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IRepository;
using Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Query;
using Features.RequestFeatures;
using System.Collections;

namespace Repositories.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DBContextProvider _dbContextProvider;
        public RepositoryBase(DBContextProvider repositoryContext)
        {
            _dbContextProvider = repositoryContext;
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? _dbContextProvider.Set<T>().AsNoTracking() :
                _dbContextProvider.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges)
        {
            return !trackChanges ? _dbContextProvider.Set<T>().Where(expression).AsNoTracking() :
                _dbContextProvider.Set<T>().Where(expression);
        }
        public void Create(T entity)
        {
            try
            {
                _dbContextProvider.Set<T>().Add(entity);
            }
            catch (Exception e)
            {

            }
        }
        public void Update(T entity)
        {
            try
            {
                _dbContextProvider.Set<T>().Update(entity);
            }
            catch (Exception e)
            {

            }
        }
        public void Delete(T entity)
        {
            try
            {
                _dbContextProvider.Set<T>().Remove(entity);
            }
            catch (Exception e)
            {

            }
        }

        public void SaveChanges()
        {
            _dbContextProvider.SaveChanges();
        }

        public IIncludableQueryable<T, TProperty> GetByWithIncludes<TProperty>(Expression<Func<T, bool>> expression, Expression<Func<T, TProperty>> include)
        {
            return _dbContextProvider.Set<T>().Where(expression).Include(include);
        }

        public IIncludableQueryable<T, TProperty> GetWithByAndInclude<TOrderBy, TProperty>(Expression<Func<T, bool>> expression, Expression<Func<T, TOrderBy>> order, Expression<Func<T, TProperty>> include, bool isASC)
        {
            var query = FindByCondition(expression, false);
            if (isASC)
            {
                query = query.OrderBy(order);
            }
            else
            {
                query = query.OrderByDescending(order);
            }

            return query.Include(include);

        }
        public  IQueryable<T> GetWithBy<TOrderBy>(Expression<Func<T, bool>> expression, Expression<Func<T, TOrderBy>> order, bool isASC)
        {
            var query = FindByCondition(expression, false);
            if (isASC)
            {
                query = query.OrderBy(order);
            }
            else
            {
                query = query.OrderByDescending(order);
            }

            return query;

        }
    }
}
