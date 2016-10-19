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
    public interface INoteRepository : Repository
    {
        /*
        IEnumerable<INote> GetAllNotesInCategory(int CategoryId);

        IEnumerable<INote> GetAllActiveNotes();*/

        Task<List<INote>> GetAsync(INoteFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams);

    }
}
