using System;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Planner.DAL.Models.Mapping;


namespace Planner.DAL.Models
{
    public partial class PlannerContext : DbContext, IPlannerContext
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




    public interface IPlannerContext : IDisposable
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<Priority> Priorities { get; set; }
        DbSet<Reminder> Reminders { get; set; }
        DbSet<Task> Tasks { get; set; }



        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        Task<int> SaveChangesAsync();


    }




}
