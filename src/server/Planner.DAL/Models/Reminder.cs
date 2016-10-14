using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Reminder")]
    public partial class Reminder
    {
        public Reminder()
        {
            this.Tasks = new List<Task>();
        }

 
        [Column("ID")] 
        public int ID { get; set; }
 
        [Column("TimeBefore")] 
        public Nullable<System.DateTime> TimeBefore { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
