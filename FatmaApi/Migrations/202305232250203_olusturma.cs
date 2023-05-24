namespace FatmaApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class olusturma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        CapacityKG = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CapacityM3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDelete = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plate = c.String(),
                        ModelYear = c.Int(nullable: false),
                        Color = c.String(),
                        ProductTypeId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Vehicles", new[] { "ProductTypeId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.ProductTypes");
        }
    }
}
