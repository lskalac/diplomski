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
    public interface INoteRepository
    {
        /*
        IEnumerable<INote> GetAllNotesInCategory(int CategoryId);

        IEnumerable<INote> GetAllActiveNotes();*/

        Task<int> InsertAsync(INote entity);
        Task<int> UpdateAsync(INote entity);

        Task<INote> GetAsync(Guid id);
        Task<List<INote>> GetAsync(INoteFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams);

        Task<int> DeleteAsync(INote entity);
        Task<int> DeleteAsync(Guid id);

    }
}
