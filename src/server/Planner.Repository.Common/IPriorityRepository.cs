using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Common.Filters;
using Planner.Common.Filters.Sorting;
using Planner.Common.Filters.Paging;
using Planner.Model.Common;

namespace Planner.Repository.Common
{
    public interface IPriorityRepository
    {
        Task<int> InsertAsync(IPriority entity);
        Task<int> UpdateAsync(IPriority entity);

        Task<IPriority> GetAsync(Guid id);
        Task<List<IPriority>> GetAsync(IPriorityFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null);

        Task<int> DeleteAsync(IPriority entity);
        Task<int> DeleteAsync(Guid id);
    }
}
