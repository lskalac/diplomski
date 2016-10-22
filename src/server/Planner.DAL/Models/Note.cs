using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Note")]
    public partial class Note
    {
 
        [Column("ID")] 
        public Guid ID { get; set; }
 
        [Column("Title")] 
        public string Title { get; set; }
 
        [Column("Text")] 
        public string Text { get; set; }
 
        [Column("IsActive")] 
        public Nullable<bool> IsActive { get; set; }
 
        [Column("CategoryID")] 
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
