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
    class PriorityService : IPriorityService 
    {

        protected IPriorityRepository Repository { get; private set; }

        PriorityService(IPriorityRepository repository)
        {
            Repository = repository;
        }



        public Task<int> InsertAsync(IPriority entity)
        {
            return Repository.InsertAsync(entity);
        }

        public Task<int> UpdateAsync(IPriority entity)
        {
            return Repository.UpdateAsync(entity);
        }



        public Task<IPriority> GetAsync(Guid id)
        {
            return Repository.GetAsync(id);
        }

        public Task<List<IPriority>> GetAsync(IPriorityFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            return Repository.GetAsync(filter, sortingParams, pagingParams);
        }



        public Task<int> DeleteAsync(IPriority entity)
        {
            return Repository.DeleteAsync(entity);
        }

        public Task<int> DeleteAsync(Guid id)
        {
            return Repository.DeleteAsync(id);
        }

    }
}
