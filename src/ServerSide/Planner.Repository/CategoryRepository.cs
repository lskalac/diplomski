using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;
using Planner.Repository.Common;
using Planner.DAL.Models;

namespace Planner.Repository
{
    //derives from generic repository (similarity of data access code)
    //additionally implements operations for ICategoryRepository interface
    class CategoryRepository : Repository<ICategory>, ICategoryRepository
    {

        public CategoryRepository(PlannerContext context)
            :base(context)
        {

        }

        public PlannerContext PlannerContext
        {
            get { return Context as PlannerContext;  }
        }

    

    }
}
