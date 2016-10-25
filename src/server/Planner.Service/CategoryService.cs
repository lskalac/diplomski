using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Common.Filters;
using Planner.Common.Filters.Paging;
using Planner.Common.Filters.Sorting;
using Planner.Model.Common;
using Planner.Repository.Common;
using Planner.Service.Common;

namespace Planner.Service
{
    class CategoryService : ICategoryService
    {

        protected ICategoryRepository Repository { get; private set; }

        CategoryService(ICategoryRepository repository)
        {
            Repository = repository;
        }



        public Task<int> InsertAsync(ICategory entity)
        {
            return Repository.InsertAsync(entity);
        }

        public Task<int> UpdateAsync(ICategory entity)
        {
            return Repository.UpdateAsync(entity);
        }
 
              

        public Task<ICategory> GetAsync(Guid id)
        {
            return Repository.GetAsync(id);
        }

        public Task<List<ICategory>> GetAsync(ICategoryFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            return Repository.GetAsync(filter, sortingParams, pagingParams);
        }



        public Task<int> DeleteAsync(ICategory entity)
        {
            return Repository.DeleteAsync(entity);
        }

        public Task<int> DeleteAsync(Guid id)
        {
            return Repository.DeleteAsync(id);
        }



    }
}
