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
using AutoMapper;
using System.Data.Entity;

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



        protected IRepository Repository { get; private set; }

        public TaskRepository(IRepository repository)
        {
            Repository = repository;
        }


        public Task<int> InsertAsync(ITask entity)
        {
            return Repository.InsertAsync<DAL.Models.Task>(Mapper.Map<DAL.Models.Task>(entity));
        }

        public Task<int> UpdateAsync(ITask entity)
        {
            return Repository.UpdateAsync<DAL.Models.Task>(Mapper.Map<DAL.Models.Task>(entity));
        }



        public async Task<ITask> GetAsync(Guid id)
        {
            return Mapper.Map<ITask>(await Repository.GetByIdAsync<DAL.Models.Task>(id));
        }

        public async Task<List<ITask>> GetAsync(ITaskFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {

            IQueryable<DAL.Models.Task> tasks = Repository.GetAllAsync<DAL.Models.Task>();

            if (filter != null)
            {
                if (filter.Title != null)
                {
                    tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks.Where(item => item.Title == filter.Title), sortingParams);
                }
                else if(filter.Date != null)
                {
                    tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks.Where(item => item.Date == filter.Date), sortingParams);
                }
                else if (filter.StartTime != null)
                {
                    tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks.Where(item => item.StartTime == filter.StartTime), sortingParams);
                }
                else if (filter.EndTime != null)
                {
                    tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks.Where(item => item.EndTime == filter.EndTime), sortingParams);
                }
                else
                {
                    tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks, sortingParams);
                }
            }
            else
            {
                tasks = SortingMethod.OrderBy<DAL.Models.Task>(tasks, sortingParams);
            }

            if (pagingParams != null)
            {
                tasks = tasks.Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize).Take(pagingParams.PageSize);
            }
            else
            {
                tasks = tasks.Take(50);
            }

            return Mapper.Map<List<ITask>>(await tasks.ToListAsync());

        }



        public async Task<int> DeleteAsync(ITask entity)
        {
            return await Repository.DeleteAsync<DAL.Models.Task>(Mapper.Map<DAL.Models.Task>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await Repository.DeleteAsync<DAL.Models.Task>(id);
        }

    }
}
