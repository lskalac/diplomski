using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            this.Notes = new List<Note>();
            this.Tasks = new List<Task>();
        }

 
        [Column("ID")] 
        public Guid ID { get; set; }

        [Column("Name")] 
        public string Name { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
