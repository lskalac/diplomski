using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.DAL.Models
{
    [Table("Note")]
    public partial class Note
    {
 
        [Column("ID")] 
        public int ID { get; set; }
 
        [Column("Title")] 
        public string Title { get; set; }
 
        [Column("Text")] 
        public string Text { get; set; }
 
        [Column("IsActive")] 
        public Nullable<byte> IsActive { get; set; }
 
        [Column("CategoryID")] 
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
