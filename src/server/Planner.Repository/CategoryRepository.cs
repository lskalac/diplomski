using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Planner.Common.Filters;
using Planner.Common.Filters.Sorting;
using Planner.Common.Filters.Paging;
using Planner.Model.Common;
using Planner.Repository.Common;
using Planner.DAL;
using Planner.DAL.Models;
using AutoMapper;

namespace Planner.Repository
{
    //derives from generic repository (similarity of data access code)
    //additionally implements operations for ICategoryRepository interface
    class CategoryRepository : ICategoryRepository
    {

        protected IRepository Repository { get; private set; }

        public CategoryRepository(IRepository repository)
        {
            Repository = repository;
        }


        public Task<int> InsertAsync(ICategory entity)
        {
            return Repository.InsertAsync<Category>(Mapper.Map<Category>(entity));
        }

        public Task<int> UpdateAsync(ICategory entity)
        {
            return Repository.UpdateAsync<Category>(Mapper.Map<Category>(entity));
        }

        

        public async Task<ICategory> GetAsync(Guid id)
        {
            return Mapper.Map<ICategory>(await Repository.GetByIdAsync<Category>(id));
        }

        public async Task<List<ICategory>> GetAsync(ICategoryFilter filter, ISortingParameters sortingParams, IPagingParameters pagingParams)
        {
            //OrderBy = SortingMethod.OrderBy<ICategory>(categories, sortingParam);
             
            IQueryable<Category> categories = Repository.GetAllAsync<Category>(); 

            if (filter != null)
            {
                if (filter.Name != null)
                {
                    categories = SortingMethod.OrderBy<Category>(categories.Where(item => item.Name == filter.Name), sortingParams);
                }
                else
                {
                    categories = SortingMethod.OrderBy<Category>(categories, sortingParams);
                }
            }
            else
            {
                categories = SortingMethod.OrderBy<Category>(categories, sortingParams);
            }

            if (pagingParams != null)
            {
                categories = categories.Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize).Take(pagingParams.PageSize);
            }
            else
            {
                categories = categories.Take(50);
            }

            //map categories to <List<ICategory>> <=> translate data from categories <List<ICategory>>:categories interface
            return Mapper.Map<List<ICategory>>(await categories.ToListAsync());
        }



        public async Task<int> DeleteAsync(ICategory entity)
        {
            return await Repository.DeleteAsync<Category>(Mapper.Map<Category>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await Repository.DeleteAsync<Category>(id);
        }



    }
}
