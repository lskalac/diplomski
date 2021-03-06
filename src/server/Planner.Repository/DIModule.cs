﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Factory;
using Planner.DAL;
using Planner.Repository.Common;

namespace Planner.Repository
{
    class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPlannerContext>().To<PlannerContext>();

            Bind<IRepository>().To<Repository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IRepositoryFactory>().ToFactory();
            Bind<IUnitOfWorkFactory>().ToFactory();

            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<INoteRepository>().To<NoteRepository>();
            Bind<IPriorityRepository>().To<PriorityRepository>();
            Bind<IReminderRepository>().To<ReminderRepository>();
            Bind<ITaskRepository>().To<TaskRepository>();

        }
    }
}
