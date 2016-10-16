using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Repository.Common
{
    public interface IUnitOfWorkFactory
    {
        //creates an instance of IUnitOfWork with injected UnitOfWork
        IUnitOfWork CreateUnitOfWork();
    }
}
