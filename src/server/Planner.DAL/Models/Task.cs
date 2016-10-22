using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Task")]
    public partial class Task
    {
 
        [Column("ID")] 
        public Guid ID { get; set; }
 
        [Column("Title")] 
        public string Title { get; set; }
 
        [Column("Date")] 
        public System.DateTime Date { get; set; }
 
        [Column("StartTime")] 
        public System.DateTime StartTime { get; set; }
 
        [Column("EndTime")] 
        public System.DateTime EndTime { get; set; }
 
        [Column("Place")] 
        public string Place { get; set; }
 
        [Column("Description")] 
        public string Description { get; set; }
 
        [Column("ReminderID")] 
        public Nullable<Guid> ReminderID { get; set; }
 
        [Column("PriorityID")] 
        public Guid PriorityID { get; set; }
 
        [Column("CategoryID")] 
        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Reminder Reminder { get; set; }
    }
}
