﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;

namespace Planner.Repository.Common
{
    public interface INoteRepository : IRepository<INote>
    {
        IEnumerable<INote> GetAllNotesInCategory(int CategoryId);

        IEnumerable<INote> GetAllActiveNotes();
    }
}
