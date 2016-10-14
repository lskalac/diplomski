using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Model.Common
{
    public interface ICategory
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
