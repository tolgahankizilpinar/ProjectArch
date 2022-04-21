using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.GenericRepository.GenericRawSql
{
    public interface IGenericRawSql
    {
        DbRawSqlQuery Execute(string connstr, Type t, string sql, params object[] parameter);
    }
}
