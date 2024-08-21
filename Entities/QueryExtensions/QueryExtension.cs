using Features.RequestFeatures;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.QueryExtensions
{
    public static class QueryExtension
    {
        public static IQueryable<T> GetPage<T>(this IQueryable<T> query, RequestFeatures Parameters)
        {
            return query.Skip((Parameters.PageNumber-1)* Parameters.PageSize).Take(Parameters.PageSize);    
        }

        public static IQueryable<T> GetPage<T, TProperty>(this IIncludableQueryable<T, TProperty> query, RequestFeatures Parameters)
        {
            return query.Skip((Parameters.PageNumber - 1) * Parameters.PageSize).Take(Parameters.PageSize);
        }
    }
}
