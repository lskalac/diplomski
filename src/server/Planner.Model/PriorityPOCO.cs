using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;

namespace Planner.Model
{
    class PriorityPOCO : IPriority
    {

        public Guid ID { get; set; }
        public string Name { get; set; }

    }
}
