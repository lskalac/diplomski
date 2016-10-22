using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    class PriorityFilter : IPriorityFilter
    {
        public string Name { get; private set; }

        PriorityFilter(string name)
        {
            Name = name;
        }

    }
}
