namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTerrainTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TerrainTypes (Id, Name) VALUES (1, 'Level')");
            Sql("INSERT INTO TerrainTypes (Id, Name) VALUES (2, 'Rolling')");
            Sql("INSERT INTO TerrainTypes (Id, Name) VALUES (3, 'Mountainous')");
        }
        
        public override void Down()
        {
        }
    }
}
