using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Model.Common;

namespace Planner.Model
{
    class NotePOCO : INote
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int CategoryID { get; set; }
    }
}
