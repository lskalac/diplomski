namespace Planner.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedTypesOfPKs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Note", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Task", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Task", "PriorityID", "dbo.Priority");
            DropForeignKey("dbo.Task", "ReminderID", "dbo.Reminder");
            DropIndex("dbo.Note", new[] { "CategoryID" });
            DropIndex("dbo.Task", new[] { "ReminderID" });
            DropIndex("dbo.Task", new[] { "PriorityID" });
            DropIndex("dbo.Task", new[] { "CategoryID" });
            DropPrimaryKey("dbo.Category");
            DropPrimaryKey("dbo.Note");
            DropPrimaryKey("dbo.Task");
            DropPrimaryKey("dbo.Priority");
            DropPrimaryKey("dbo.Reminder");
            AlterColumn("dbo.Category", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Note", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Note", "CategoryID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Task", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Task", "ReminderID", c => c.Guid());
            AlterColumn("dbo.Task", "PriorityID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Task", "CategoryID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Priority", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Reminder", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Category", "ID");
            AddPrimaryKey("dbo.Note", "ID");
            AddPrimaryKey("dbo.Task", "ID");
            AddPrimaryKey("dbo.Priority", "ID");
            AddPrimaryKey("dbo.Reminder", "ID");
            CreateIndex("dbo.Note", "CategoryID");
            CreateIndex("dbo.Task", "ReminderID");
            CreateIndex("dbo.Task", "PriorityID");
            CreateIndex("dbo.Task", "CategoryID");
            AddForeignKey("dbo.Note", "CategoryID", "dbo.Category", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Task", "CategoryID", "dbo.Category", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Task", "PriorityID", "dbo.Priority", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Task", "ReminderID", "dbo.Reminder", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "ReminderID", "dbo.Reminder");
            DropForeignKey("dbo.Task", "PriorityID", "dbo.Priority");
            DropForeignKey("dbo.Task", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Note", "CategoryID", "dbo.Category");
            DropIndex("dbo.Task", new[] { "CategoryID" });
            DropIndex("dbo.Task", new[] { "PriorityID" });
            DropIndex("dbo.Task", new[] { "ReminderID" });
            DropIndex("dbo.Note", new[] { "CategoryID" });
            DropPrimaryKey("dbo.Reminder");
            DropPrimaryKey("dbo.Priority");
            DropPrimaryKey("dbo.Task");
            DropPrimaryKey("dbo.Note");
            DropPrimaryKey("dbo.Category");
            AlterColumn("dbo.Reminder", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Priority", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Task", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Task", "PriorityID", c => c.Int(nullable: false));
            AlterColumn("dbo.Task", "ReminderID", c => c.Int());
            AlterColumn("dbo.Task", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Note", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Note", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Category", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reminder", "ID");
            AddPrimaryKey("dbo.Priority", "ID");
            AddPrimaryKey("dbo.Task", "ID");
            AddPrimaryKey("dbo.Note", "ID");
            AddPrimaryKey("dbo.Category", "ID");
            CreateIndex("dbo.Task", "CategoryID");
            CreateIndex("dbo.Task", "PriorityID");
            CreateIndex("dbo.Task", "ReminderID");
            CreateIndex("dbo.Note", "CategoryID");
            AddForeignKey("dbo.Task", "ReminderID", "dbo.Reminder", "ID");
            AddForeignKey("dbo.Task", "PriorityID", "dbo.Priority", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Task", "CategoryID", "dbo.Category", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Note", "CategoryID", "dbo.Category", "ID", cascadeDelete: true);
        }
    }
}
