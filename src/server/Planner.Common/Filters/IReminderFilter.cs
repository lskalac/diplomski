﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Common.Filters
{
    public interface IReminderFilter
    {
        DateTime? TimeBefore { get; }
    }
}
