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
    class ReminderRepository :  IReminderRepository
    {

        protected IRepository Repository { get; private set; }

        ReminderRepository(IRepository repository)
        {
            Repository = repository;
        }


        public Task<int> InsertAsync(IReminder entity)
        {
            return Repository.InsertAsync<Reminder>(Mapper.Map<Reminder>(entity));
        }

        public Task<int> UpdateAsync(IReminder entity)
        {
            return Repository.UpdateAsync<Reminder>(Mapper.Map<Reminder>(entity));
        }



        public async Task<IReminder> GetAsync(Guid id)
        {
            return Mapper.Map<IReminder>(await Repository.GetByIdAsync<Reminder>(id));
        }


        public async Task<List<IReminder>> GetAsync(IReminderFilter filter = null, ISortingParameters sortingParams = null, IPagingParameters pagingParams = null)
        {
            IQueryable<Reminder> reminders = Repository.GetAllAsync<Reminder>();

            if (filter != null)
            {
                if (filter.TimeBefore != null)
                {
                    reminders = SortingMethod.OrderBy<Reminder>(reminders.Where(item => item.TimeBefore == filter.TimeBefore), sortingParams);
                }
                else
                {
                    reminders = SortingMethod.OrderBy<Reminder>(reminders, sortingParams);
                }
            }
            else
            {
                reminders = SortingMethod.OrderBy<Reminder>(reminders, sortingParams);
            }

            if (pagingParams != null)
            {
                reminders = reminders.Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize).Take(pagingParams.PageSize);
            }
            else
            {
                reminders = reminders.Take(50);
            }

            return Mapper.Map<List<IReminder>>(await reminders.ToListAsync());
        }



        public async Task<int> DeleteAsync(IReminder entity)
        {
            return await Repository.DeleteAsync<Reminder>(Mapper.Map<Reminder>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await Repository.DeleteAsync<Reminder>(id);
        }


    }
}
