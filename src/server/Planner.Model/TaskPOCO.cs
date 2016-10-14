using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;

namespace Planner.Model
{
    class TaskPOCO : ITask
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }

        public Nullable<int> ReminderID { get; set; }
        public int PriorityID { get; set; }
        public int CategoryID { get; set; }

    }
}
