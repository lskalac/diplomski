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
    class TaskService : ITaskService
    {

        protected ITaskRepository Repository { get; private set; }

        TaskService(ITaskRepository repository)
        {
            Repository = repository;
        }



        public Task<int> InsertAsync(ITask entity)
        {
            return Repository.InsertAsync(entity);
        }

        public Task<int> UpdateAsync(ITask entity)
        {
            return Repository.UpdateAsync(entity);
        }



        public Task<ITask> GetAsync(Guid id)
        {
            return Repository.GetAsync(id);
        }

        public Task<List<ITask>> GetAsync(ITaskFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            return Repository.GetAsync(filter, sortingParams, pagingParams);
        }



        public Task<int> DeleteAsync(ITask entity)
        {
            return Repository.DeleteAsync(entity);
        }

        public Task<int> DeleteAsync(Guid id)
        {
            return Repository.DeleteAsync(id);
        }

    }
}
