namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDirectionTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DirectionTypes (Id, Name) VALUES (1, 'Downstation')");
            Sql("INSERT INTO DirectionTypes (Id, Name) VALUES (2, 'Upstation')");

        }

        public override void Down()
        {
        }
    }
}

