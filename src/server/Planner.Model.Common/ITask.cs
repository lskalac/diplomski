using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Model.Common
{
    public interface ITask
    {
        Guid ID { get; set; }
        string Title { get; set; }
        System.DateTime Date { get; set; }
        System.DateTime StartTime { get; set; }
        System.DateTime EndTime { get; set; }
        string Place { get; set; }
        string Description { get; set; }

        Nullable<Guid> ReminderID { get; set; }
        Guid PriorityID { get; set; }
        Guid CategoryID { get; set; }
    }
}
