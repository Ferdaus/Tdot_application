namespace Tdot_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToProjectCRS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "CRS", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "CRS", c => c.String());
        }
    }
}
