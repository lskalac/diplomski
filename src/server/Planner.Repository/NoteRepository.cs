using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Common.Filters;
using Planner.Common.Filters.Paging;
using Planner.Common.Filters.Sorting;
using Planner.DAL.Models;
using Planner.Model.Common;
using Planner.Repository.Common;
using System.Data.Entity;
using AutoMapper;


namespace Planner.Repository
{
    class NoteRepository : Repository, INoteRepository
    {
        /*public NoteRepository(PlannerContext context)
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
       }*/
        public NoteRepository(IPlannerContext dbContext, IUnitOfWorkFactory unitOfWorkFactory) 
            : base(dbContext, unitOfWorkFactory)
        {
        }

        public async Task<List<INote>> GetAsync(INoteFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams)
        {
            IQueryable<Note> notes = GetAllAsync<Note>();

            if (filter != null)
            {
                if (filter.Title != null)
                {
                    notes = SortingMethod.OrderBy<Note>(notes.Where(item => item.Title == filter.Title), sortingParams);
                }
                else if(filter.IsActive != null)
                {
                    notes = SortingMethod.OrderBy<Note>(notes.Where(item => item.IsActive == filter.IsActive), sortingParams);
                }
                else
                {
                    notes = SortingMethod.OrderBy<Note>(notes, sortingParams);
                }
            }
            else
            {
                notes = SortingMethod.OrderBy<Note>(notes, sortingParams);
            }

            if (pagingParams != null)
            {
                notes = notes.Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize).Take(pagingParams.PageSize);
            }
            else
            {
                notes = notes.Take(50);
            }

            return Mapper.Map<List<INote>>(await notes.ToListAsync());
        }
    }
}
