using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Model.Common
{
    public interface INote
    {
        int ID { get; set; }
        string Title { get; set; }
        string Text { get; set; }
        Nullable<bool> IsActive { get; set; }
        int CategoryID { get; set; }
    }
}
