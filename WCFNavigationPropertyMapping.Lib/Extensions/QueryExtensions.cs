using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFNavigationPropertyMapping.Contracts.Options;

namespace WCFNavigationPropertyMapping.Lib.Extensions
{
    public static class QueryExtensions
    {
        public static IQueryable<T> AddIncludeStatements<T>(this IQueryable<T> query, OptionsBase options)
        {
            var names = options.GetSelectedOptions();
            var dbQuery = (DbQuery<T>)query;
            foreach (var name in names)
            {
                dbQuery = dbQuery.Include(name);
            }
            return dbQuery;
        }
    }
}
