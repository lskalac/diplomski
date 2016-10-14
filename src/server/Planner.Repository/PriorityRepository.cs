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
    class PriorityRepository : Repository<IPriority>, IPriorityRepository
    {
        public PriorityRepository(PlannerContext context)
             :base(context)
         {

        }

        public PlannerContext PlannerContext
        {
            get { return Context as PlannerContext; }
        }



    }
}
