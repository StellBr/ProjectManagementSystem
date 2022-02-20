using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Data;

namespace Common.Repositories
{
    public class UnitOfWork
    {
        public DbContext Context { get; set; }

        private IDbContextTransaction Transaction { get; set; }

        public UnitOfWork()
        {
            Context = new MyDbContext();
        }

       public void BeginTransaction()
        {
            Transaction = Context.Database.BeginTransaction();
        }

      public void Commit()
        {
            if (Transaction != null)
                Transaction.Commit();
        }

        public void Rollback()
        {
            if (Transaction != null)
                Transaction.Rollback();
        }
    }
}
