using System;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Planner.DAL.Models;
using Planner.DAL.Models.Mapping;


namespace Planner.DAL
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
        public DbSet<Models.Task> Tasks { get; set; }

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
        DbSet<Models.Task> Tasks { get; set; }


        //for access to entities of the given type in the context and the underlying store
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        //provides access to information about the entity and the ability to perform actions on the entity
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        //Asynchronously saves all changes made in this context to the underlying database
        //result: number of objects written to the underlying database
        Task<int> SaveChangesAsync();


    }




}
