using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    class CategoryFilter : ICategoryFilter
    {
        public string Name { get; private set; }

        public CategoryFilter(string name)
        {
            Name = name;
        }

    }
}
