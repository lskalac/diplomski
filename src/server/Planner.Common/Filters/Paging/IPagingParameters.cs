using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters.Paging
{
    public interface IPagingParameters
    {
        int PageNumber { get; }
        int PageSize { get; }
    }
}
