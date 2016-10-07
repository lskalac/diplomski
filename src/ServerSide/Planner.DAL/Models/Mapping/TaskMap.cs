using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Planner.DAL.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.Place)
                .HasMaxLength(45);

            this.Property(t => t.Description)
                .HasMaxLength(45);


            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.CategoryID);
            this.HasRequired(t => t.Priority)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.PriorityID);
            this.HasOptional(t => t.Reminder)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.ReminderID);

        }
    }
}
