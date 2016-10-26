using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    public interface ITaskFilter
    {
        string Title { get; }
        DateTime Date { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }  

    }
}
