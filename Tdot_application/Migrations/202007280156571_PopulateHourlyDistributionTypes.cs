namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHourlyDistributionTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO HourlyDistributionTypes (Id, Name) VALUES (1, 'User Defined')");
            Sql("INSERT INTO HourlyDistributionTypes (Id, Name) VALUES (2, 'Urban')");
            Sql("INSERT INTO HourlyDistributionTypes (Id, Name) VALUES (3, 'Rural')");
        }
        
        public override void Down()
        {
        }
    }
}
