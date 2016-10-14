using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Priority")]
    public partial class Priority
    {
        public Priority()
        {
            this.Tasks = new List<Task>();
        }

 
        [Column("ID")] 
        public int ID { get; set; }
 
        [Column("Name")] 
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
