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
    class PriorityRepository : IPriorityRepository
    {

        protected IRepository Repository { get; private set; }

        PriorityRepository(IRepository repository)
        {
            Repository = repository;
        }


        public Task<int> InsertAsync(IPriority entity)
        {
            return Repository.InsertAsync<Priority>(Mapper.Map<Priority>(entity));
        }

        public Task<int> UpdateAsync(IPriority entity)
        {
            return Repository.UpdateAsync<Priority>(Mapper.Map<Priority>(entity));
        }



        public async Task<IPriority> GetAsync(Guid id)
        {
            return Mapper.Map<IPriority>(await Repository.GetByIdAsync<Priority>(id));
        }


        public async Task<List<IPriority>> GetAsync(IPriorityFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            IQueryable<Priority> priorities = Repository.GetAllAsync<Priority>();

            if (filter != null)
            {
                if (filter.Name != null)
                {
                    priorities = SortingMethod.OrderBy<Priority>(priorities.Where(item => item.Name == filter.Name), sortingParams);
                }
                else
                {
                    priorities = SortingMethod.OrderBy<Priority>(priorities, sortingParams);
                }
            }
            else
            {
                priorities = SortingMethod.OrderBy<Priority>(priorities, sortingParams);
            }

            if (pagingParams != null)
            {
                priorities = priorities.Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize).Take(pagingParams.PageSize);
            }
            else
            {
                priorities = priorities.Take(50);
            }

            return Mapper.Map<List<IPriority>>(await priorities.ToListAsync());
        }



        public async Task<int> DeleteAsync(IPriority entity)
        {
            return await Repository.DeleteAsync<Priority>(Mapper.Map<Priority>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await Repository.DeleteAsync<Priority>(id);
        }


    }
}
