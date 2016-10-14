using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        INoteRepository Notes { get; }

        void Complete();
    }
}
