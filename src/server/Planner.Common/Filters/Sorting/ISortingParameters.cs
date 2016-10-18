using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters.Sorting
{
    public interface ISortingParameters
    {
        IList<ISortingParam> Sorters { get; }
    }
}
