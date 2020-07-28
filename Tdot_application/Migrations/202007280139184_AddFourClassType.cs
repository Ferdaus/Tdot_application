namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFourClassType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DirectionTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HourlyDistributionTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TerrainTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VolumeDataTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Projects", "VolumeDataTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Projects", "HourlyDistributionTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Projects", "DirectionTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Projects", "TerrainTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Projects", "VolumeDataTypeId");
            CreateIndex("dbo.Projects", "HourlyDistributionTypeId");
            CreateIndex("dbo.Projects", "DirectionTypeId");
            CreateIndex("dbo.Projects", "TerrainTypeId");
            AddForeignKey("dbo.Projects", "DirectionTypeId", "dbo.DirectionTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "HourlyDistributionTypeId", "dbo.HourlyDistributionTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "TerrainTypeId", "dbo.TerrainTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "VolumeDataTypeId", "dbo.VolumeDataTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Projects", "VolumeDataType");
            DropColumn("dbo.Projects", "HourlyDistributionType");
            DropColumn("dbo.Projects", "DirectionOfTravel");
            DropColumn("dbo.Projects", "TerrainType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "TerrainType", c => c.String());
            AddColumn("dbo.Projects", "DirectionOfTravel", c => c.String());
            AddColumn("dbo.Projects", "HourlyDistributionType", c => c.String());
            AddColumn("dbo.Projects", "VolumeDataType", c => c.String());
            DropForeignKey("dbo.Projects", "VolumeDataTypeId", "dbo.VolumeDataTypes");
            DropForeignKey("dbo.Projects", "TerrainTypeId", "dbo.TerrainTypes");
            DropForeignKey("dbo.Projects", "HourlyDistributionTypeId", "dbo.HourlyDistributionTypes");
            DropForeignKey("dbo.Projects", "DirectionTypeId", "dbo.DirectionTypes");
            DropIndex("dbo.Projects", new[] { "TerrainTypeId" });
            DropIndex("dbo.Projects", new[] { "DirectionTypeId" });
            DropIndex("dbo.Projects", new[] { "HourlyDistributionTypeId" });
            DropIndex("dbo.Projects", new[] { "VolumeDataTypeId" });
            DropColumn("dbo.Projects", "TerrainTypeId");
            DropColumn("dbo.Projects", "DirectionTypeId");
            DropColumn("dbo.Projects", "HourlyDistributionTypeId");
            DropColumn("dbo.Projects", "VolumeDataTypeId");
            DropTable("dbo.VolumeDataTypes");
            DropTable("dbo.TerrainTypes");
            DropTable("dbo.HourlyDistributionTypes");
            DropTable("dbo.DirectionTypes");
        }
    }
}
