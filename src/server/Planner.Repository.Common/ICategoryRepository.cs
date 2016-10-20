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
    //any operations specific for categories that aren't in generic repository
    public interface ICategoryRepository : Repository
    {
        Task<int> InsertAsync(ICategory entity);
        Task<int> UpdateAsync(ICategory entity);

        Task<ICategory> GetAsync(int id);
        Task<List<ICategory>> GetAsync(ICategoryFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams);

        Task<int> DeleteAsync(ICategory entity);
        Task<int> DeleteAsync(int id);
    }
}
