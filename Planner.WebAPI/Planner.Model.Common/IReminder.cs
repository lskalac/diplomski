using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Model.Common
{
    public interface IReminder
    {
        int ID { get; set; }
        Nullable<System.DateTime> TimeBefore { get; set; }
    }
}
