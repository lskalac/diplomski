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
    class ReminderService : IReminderService
    {
        protected IReminderRepository Repository { get; private set; }

        ReminderService(IReminderRepository repository)
        {
            Repository = repository;
        }



        public Task<int> InsertAsync(IReminder entity)
        {
            return Repository.InsertAsync(entity);
        }

        public Task<int> UpdateAsync(IReminder entity)
        {
            return Repository.UpdateAsync(entity);
        }



        public Task<IReminder> GetAsync(Guid id)
        {
            return Repository.GetAsync(id);
        }

        public Task<List<IReminder>> GetAsync(IReminderFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            return Repository.GetAsync(filter, sortingParams, pagingParams);
        }



        public Task<int> DeleteAsync(IReminder entity)
        {
            return Repository.DeleteAsync(entity);
        }

        public Task<int> DeleteAsync(Guid id)
        {
            return Repository.DeleteAsync(id);
        }
    }
}
