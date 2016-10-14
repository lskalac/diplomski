using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.DAL.Models;
using Planner.Model.Common;
using Planner.Repository.Common;
using System.Data.Entity;

namespace Planner.Repository
{
    class NoteRepository : Repository<INote>, INoteRepository
    {
         public NoteRepository(PlannerContext context)
             :base(context)
         {

         }

         public PlannerContext PlannerContext
         {
             get { return Context as PlannerContext; }
         }


        public IEnumerable<INote> GetAllNotesInCategory(int CategoryId)
        {
            return PlannerContext.Set<INote>()
                .Where(n => n.ID == CategoryId)
                .ToList();
        }

        public IEnumerable<INote> GetAllActiveNotes()
        {
            return PlannerContext.Set<INote>()
                //.Where(n => n.IsActive == true)
                .ToList();
        }


    }
}
