namespace Planner.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePriorityTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Priority (ID, Name) VALUES (1, 'Very Important')");
            Sql("INSERT INTO Priority (ID, Name) VALUES (2, 'Important')");
            Sql("INSERT INTO Priority (ID, Name) VALUES (3, 'Less Important')");

        }

        //update-database default goes to the last migration
        //Down() must be opposite od Up()

        public override void Down()
        {
            Sql("DELETE FROM Priority WHERE ID IN (1, 2, 3, 4)");
        }
    }
}
