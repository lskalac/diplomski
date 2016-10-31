using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    class ReminderFilter : IReminderFilter
    {
        public DateTime? TimeBefore{ get; private set; }

        public ReminderFilter(DateTime? timeBefore)
        {
            TimeBefore = timeBefore;
        }
    }
}
