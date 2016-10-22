using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Planner.DAL;
using Planner.DAL.Models;
using Planner.Repository.Common;

namespace Planner.Repository
{
    //mediates between the domain and data mapping layers using a 
    //collection-like interface for accessing domain objects

    class Repository : Common.Repository
    {

        protected IPlannerContext DbContext { get; private set; }
        protected IUnitOfWorkFactory UnitOfWorkFactory { get; private set; }

        public Repository(IPlannerContext dbContext, IUnitOfWorkFactory unitOfWorkFactory)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("DbContext");
            }
            DbContext = dbContext;
            UnitOfWorkFactory = unitOfWorkFactory;
        }



        public IUnitOfWork CreateUnitOfWork()
        {
            return UnitOfWorkFactory.CreateUnitOfWork();
        }


        public async Task<int> InsertAsync<T>(T entity) where T : class
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
            return await DbContext.SaveChangesAsync();
        }




        public async Task<int> UpdateAsync<T>(T entity) where T : class
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbContext.Set<T>().Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
            return await DbContext.SaveChangesAsync();
        }




        public IQueryable<T> GetAllAsync<T>() where T : class
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public Task<T> GetByIdAsync<T>(Guid id) where T : class
        {
            return DbContext.Set<T>().FindAsync(id);
        }



        public async Task<int> DeleteAsync<T>(T entity) where T : class
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
            return await DbContext.SaveChangesAsync();
        }


        public async Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            var entity = await GetByIdAsync<T>(id);
            if (entity == null)
            {
                throw new KeyNotFoundException("Entity with specified ID not found.");
            }
            return await DeleteAsync<T>(entity);
        }




    }
}
