using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Planner.Repository.Common;

namespace Planner.Repository
{
    class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<INoteRepository>().To<NoteRepository>();

        }
    }
}
