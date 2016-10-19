using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    class NoteFilter : INoteFilter
    {

        public string Title { get; private set; }
        public bool? IsActive { get; private set; }


        NoteFilter(string title, bool? isActive)
        {
            Title = title;
            IsActive = isActive;
        }

    }
}
