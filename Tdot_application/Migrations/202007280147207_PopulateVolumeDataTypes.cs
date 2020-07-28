namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVolumeDataTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VolumeDataTypes (Id, Name) VALUES (1, 'AADT')");
            Sql("INSERT INTO VolumeDataTypes (Id, Name) VALUES (2, 'Hourly')");
        }
        
        public override void Down()
        {
        }
    }
}
