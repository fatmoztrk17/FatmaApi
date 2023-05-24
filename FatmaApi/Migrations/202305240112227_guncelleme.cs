namespace FatmaApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guncelleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductTypes", "Brand", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductTypes", "Brand", c => c.String());
        }
    }
}
