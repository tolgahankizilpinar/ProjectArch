using Arch.Data.Context;
using Arch.Data.GenericRepository;
using Arch.Data.GenericRepository.GenericRawSql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ArchContext _context;
        private readonly CommonContext _cContext;
        private DbContextTransaction trans = null;
        private bool disposed = false;

        public UnitofWork(ArchContext context, CommonContext cContext)
        {
            Database.SetInitializer<ArchContext>(null);
            if (context == null)
            {
                throw new ArgumentException("context is null");
            }

            _cContext = cContext;
            _context = context;
        }

       
        public IGenericRawSql GetRawSql()
        {
            return new GenericRawSql(_cContext);
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }

        public void BeginTransaction()
        {
            trans = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            trans.Commit();
        }

        public void Rollback()
        {
            trans.Rollback();
        }

        public int SaveChanges()
        {
            int affectedRow = 0;

            try
            {
                affectedRow = _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var message = string.Empty;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        message += string.Format("Property : {0}, Error : {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(message, dbEx);
            }
            return affectedRow;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
