using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using Planner.DAL;
using Planner.Repository.Common;


namespace Planner.Repository
{
    //maintains a list of object affected by a business transaction
    //and coordinates the writing out of changes

    public class UnitOfWork : IUnitOfWork
    {


        protected IPlannerContext DbContext { get; private set; }

        public UnitOfWork(IPlannerContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("DbContext");
            }
            DbContext = dbContext;
        }



        public virtual Task<int> AddAsync<T>(T entity) where T : class
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbContext.Set<T>().Add(entity);
            }
            return System.Threading.Tasks.Task.FromResult(1);
        }



        public virtual Task<int> UpdateAsync<T>(T entity) where T : class
        {

            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbContext.Set<T>().Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
            return System.Threading.Tasks.Task.FromResult(1);
        }



        public virtual Task<int> DeleteAsync<T>(T entity) where T : class
        {

            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbContext.Set<T>().Attach(entity);
                DbContext.Set<T>().Remove(entity);
            }
            return System.Threading.Tasks.Task.FromResult(1);
            

        }


        public virtual Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            var entity = DbContext.Set<T>().Find(id);
            if (entity == null)
            {
                return System.Threading.Tasks.Task.FromResult(0);
            }
            return DeleteAsync<T>(entity);
        }



        public async Task<int> CommitAsync()
        {
            int result = 0;
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                result = await DbContext.SaveChangesAsync();
                scope.Complete();
            }
            return result;
        }



        public void Dispose()
        {
            DbContext.Dispose();
        }
        


    }
}
