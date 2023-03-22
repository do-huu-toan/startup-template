using Sample.Entity;
using Sample.Infratructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infratructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleDbContext _context;
        private bool _disposed = false;

        public UnitOfWork(SampleDbContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            bool returnValue = true;
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    returnValue = false;
                    dbContextTransaction.Rollback();
                }
            }
            return returnValue;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
