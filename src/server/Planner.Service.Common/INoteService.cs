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
    public interface INoteService
    {
        Task<int> InsertAsync(INote entity);
        Task<int> UpdateAsync(INote entity);

        Task<INote> GetAsync(Guid id);
        Task<List<INote>> GetAsync(INoteFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams);

        Task<int> DeleteAsync(INote entity);
        Task<int> DeleteAsync(Guid id);

    }
}
