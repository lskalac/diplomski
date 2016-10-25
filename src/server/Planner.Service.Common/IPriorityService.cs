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
    public interface IPriorityService
    {
        Task<int> InsertAsync(IPriority entity);
        Task<int> UpdateAsync(IPriority entity);

        Task<IPriority> GetAsync(Guid id);
        Task<List<IPriority>> GetAsync(IPriorityFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams);

        Task<int> DeleteAsync(IPriority entity);
        Task<int> DeleteAsync(Guid id);

    }
}
