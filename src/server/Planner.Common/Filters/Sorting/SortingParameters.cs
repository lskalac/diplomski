using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters.Sorting
{
    class SortingParameters : ISortingParameters
    {
        public IList<ISortingParam> Sorters { get;  set; }

        public SortingParameters()
        {
            Sorters = new List<ISortingParam>();
        }
    }
}
