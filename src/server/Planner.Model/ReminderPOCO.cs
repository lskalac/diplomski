using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;

namespace Planner.Model
{
    class ReminderPOCO : IReminder
    {
  
        public Guid ID { get; set; }
        public Nullable<System.DateTime> TimeBefore { get; set; }

    }

}
