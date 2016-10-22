using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Model.Common
{
    public interface INote
    {
        Guid ID { get; set; }
        string Title { get; set; }
        string Text { get; set; }
        Nullable<bool> IsActive { get; set; }
        Guid CategoryID { get; set; }
    }
}
