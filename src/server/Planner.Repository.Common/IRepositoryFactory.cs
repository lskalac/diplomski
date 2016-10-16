using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Repository.Common
{
    //contain all entity repository
    //adding new entity <=> adding new entry into this interface
    public interface IRepositoryFactory
    {
        //creates an intance of enetity repository
        ICategoryRepository CreateCategoryRepository();
        INoteRepository CreateNoteRepository();
        IPriorityRepository CreatePriorityRepository();
        IReminderRepository CreateReminderRepository();
        ITaskRepository CreateTaskRepository();

    }
}
