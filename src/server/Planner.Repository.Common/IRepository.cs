using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Repository.Common
{   
    //generic - can be used for any application
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        void Insert(TEntity entity);

        void Update(TEntity entity);

 
        void Delete(TEntity entity);

        void Delete(int id);

    }
}
