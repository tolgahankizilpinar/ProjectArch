using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);  // get the all list according to where clause

        T GetById(object id);
        T Get(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(List<T> entityList);

        void Update(T entity);
        void Delete(T entity);
    }
}
