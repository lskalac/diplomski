using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Planner.Model.Common;

namespace Planner.Model
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            //binding services to inject
            //injecting entities while using interfaces

            Bind<ICategory>().To<CategoryPOCO>();
            Bind<INote>().To<NotePOCO>();
            Bind<IPriority>().To<PriorityPOCO>();
            Bind<IReminder>().To<ReminderPOCO>();
            Bind<ITask>().To<TaskPOCO>();
        }
    }
}
