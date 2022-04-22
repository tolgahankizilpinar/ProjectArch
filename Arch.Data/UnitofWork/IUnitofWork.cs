using Arch.Data.GenericRepository;
using Arch.Data.GenericRepository.GenericRawSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class;
        IGenericRawSql GetRawSql();

        int SaveChanges();

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
