using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Common.Filters;
using Planner.Common.Filters.Paging;
using Planner.Common.Filters.Sorting;
using Planner.Model.Common;

namespace Planner.Service.Common
{
    public interface ITaskService
    {
        Task<int> InsertAsync(ITask entity);
        Task<int> UpdateAsync(ITask entity);

        Task<ITask> GetAsync(Guid id);
        Task<List<ITask>> GetAsync(ITaskFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null);

        Task<int> DeleteAsync(ITask entity);
        Task<int> DeleteAsync(Guid id);
    }
}
