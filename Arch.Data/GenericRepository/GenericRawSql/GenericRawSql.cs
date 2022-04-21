using Arch.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.GenericRepository.GenericRawSql
{
    public class GenericRawSql : IGenericRawSql
    {
        private readonly CommonContext _context; 

        public GenericRawSql(CommonContext context)
        {
            _context = context;
        }

        public DbRawSqlQuery Execute(string connstr, Type t, string sql, params object[] parameter)
        {
            _context.Database.Connection.ConnectionString = connstr;

            return _context.Database.SqlQuery(t, sql, parameter);
        }
    }
}
