namespace Okaz.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CategotyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategotyId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Rating");
        }
    }
}
