using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    public interface INoteFilter
    {
        string Title { get; }
        bool? IsActive { get; }
    }
}
