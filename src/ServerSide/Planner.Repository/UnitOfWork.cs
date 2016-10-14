using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.DAL.Models;
using Planner.Repository.Common;

namespace Planner.Repository
{
    //maintains a list of object affected by a business transaction
    //and coordinates the writing out of changes

    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly PlannerContext Context;

        public ICategoryRepository Categories { get; private set; }
        public INoteRepository Notes { get; private set; }


        public UnitOfWork(PlannerContext context)
        {
            Context = context;
            Categories = new CategoryRepository(context);
            Notes = new NoteRepository(context);
        }


        public void Complete()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
