using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Planner.Service.Common;

namespace Planner.Service
{
    class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryService>();
            Bind<INoteService>().To<NoteService>();
            Bind<IPriorityService>().To<PriorityService>();
            Bind<ITaskService>().To<TaskService>();
        }
    }
}
