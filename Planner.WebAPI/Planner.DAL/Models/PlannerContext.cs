using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Planner.DAL.Models.Mapping;

namespace Planner.DAL.Models
{
    public partial class PlannerContext : DbContext
    {
        static PlannerContext()
        {
            Database.SetInitializer<PlannerContext>(null);
        }

        public PlannerContext()
            : base("Name=PlannerContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new NoteMap());
            modelBuilder.Configurations.Add(new PriorityMap());
            modelBuilder.Configurations.Add(new ReminderMap());
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
