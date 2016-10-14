using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Planner.Repository.Common;

namespace Planner.Repository
{
    //mediates between the domain and data mapping layers using a 
    //collection-like interface for accessing domain objects

    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        //constructor
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }


        //methods
        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }


        public void Insert(TEntity entity)
        {

            Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = Context.Set<TEntity>().Find(id);
            Delete(entityToDelete);
        }




    }
}
