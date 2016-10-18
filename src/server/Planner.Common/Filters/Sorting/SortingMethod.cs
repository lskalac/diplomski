using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;


namespace Planner.Common.Filters.Sorting
{
    public static class SortingMethod
    {
        public static IQueryable<T> OrderBy<T>(IQueryable<T> collection, ISortingParameters sortingParams)
        {
            if(sortingParams != null)
            {
                IQueryable<T> sorted = null;
                foreach(var sorter in sortingParams.Sorters)
                {
                    sorted = collection.OrderBy(sorter.GetSortExpression());
                }
                return sorted;
            } else
            {
                return collection;
            }
        }
    }
}
