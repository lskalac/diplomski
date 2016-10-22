using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Repository.Common
{   
    //generic - can be used for any application
    public interface IRepository
    {

        IUnitOfWork CreateUnitOfWork();


        Task<int> InsertAsync<T>(T entity) where T : class;
        Task<int> UpdateAsync<T>(T entity) where T : class;

        IQueryable<T> GetAllAsync<T>() where T : class;
        Task<T> GetByIdAsync<T>(Guid id) where T : class;

        Task<int> DeleteAsync<T>(T entity) where T : class;
        Task<int> DeleteAsync<T>(Guid id) where T : class;


    }
}
