using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters.Sorting
{
    class SortingPair : ISortingPair
    {
        public bool Ascending { get; private set; }
        public string OrderBy { get; private set; }

        public SortingPair(bool ascending, string orderBy)
        {
            Ascending = ascending;
            OrderBy = orderBy;
        }

        public string GetSortExpression()
        {
            return String.Format("{0} {1}", this.OrderBy, this.Ascending ? String.Empty : "descending");
        }

    }
}
