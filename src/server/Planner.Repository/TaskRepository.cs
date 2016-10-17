using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.DAL.Models;
using Planner.Model.Common;
using Planner.Repository.Common;

namespace Planner.Repository
{
    class TaskRepository : ITaskRepository
    {
       /* public TaskRepository(PlannerContext context)
            :base(context)
        {

        }

        public PlannerContext PlannerContext
        {
            get { return Context as PlannerContext; }
        }

        public IEnumerable<ITask> GetAllTaskInCategory(int CategoryId)
        {
            return PlannerContext.Set<ITask>()
                .Where(t => t.ID == CategoryId)
                .ToList();
        }

        public IEnumerable<ITask> GetAllTaskWithPriority(int PriorityId)
        {
            return PlannerContext.Set<ITask>()
                .Where(t => t.ID == PriorityId)
                .ToList();
        }*/
    }
}
