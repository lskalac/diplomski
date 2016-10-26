using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    class TaskFilter : ITaskFilter
    {

        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public TaskFilter(string title, DateTime date, DateTime startTime, DateTime endTime )
        {
            Title = title;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }


    }
}
