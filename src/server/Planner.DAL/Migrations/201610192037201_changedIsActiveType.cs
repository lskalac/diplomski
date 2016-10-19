namespace Planner.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedIsActiveType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "IsActive", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "IsActive", c => c.Byte());
        }
    }
}
