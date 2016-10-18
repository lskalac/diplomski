using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters.Paging
{
    class PagingParameters : IPagingParameters
    {
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }

        private int MaxPageSize = 100;

        PagingParameters(int pageNumber, int pageSize)
        {
            PageNumber = (pageNumber > 0) ? pageNumber : 1;
            PageSize = (pageSize > 0 && pageSize <= MaxPageSize) ? pageSize : MaxPageSize;
        }

    }
}
