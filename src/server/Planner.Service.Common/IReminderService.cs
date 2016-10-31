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
    public interface IReminderService
    {
        Task<int> InsertAsync(IReminder entity);
        Task<int> UpdateAsync(IReminder entity);

        Task<IReminder> GetAsync(Guid id);
        Task<List<IReminder>> GetAsync(IReminderFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null);

        Task<int> DeleteAsync(IReminder entity);
        Task<int> DeleteAsync(Guid id);
    }
}
