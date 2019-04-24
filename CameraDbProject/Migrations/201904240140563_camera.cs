namespace CameraDbProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Model = c.String(),
                        Year = c.String(),
                        MaxResolution = c.Decimal(precision: 18, scale: 2),
                        LowResolution = c.Decimal(precision: 18, scale: 2),
                        EffectivePixels = c.Decimal(precision: 18, scale: 2),
                        ZoomWide = c.Decimal(precision: 18, scale: 2),
                        ZoomTele = c.Decimal(precision: 18, scale: 2),
                        NormalFocusRange = c.Decimal(precision: 18, scale: 2),
                        MacroFocusRange = c.Decimal(precision: 18, scale: 2),
                        StorageIncluded = c.Decimal(precision: 18, scale: 2),
                        Weight = c.Decimal(precision: 18, scale: 2),
                        Dimensions = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cameras");
        }
    }
}
