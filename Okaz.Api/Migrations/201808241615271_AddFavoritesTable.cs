namespace Okaz.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFavoritesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Favorite_Id", c => c.Int());
            CreateIndex("dbo.Products", "Favorite_Id");
            AddForeignKey("dbo.Products", "Favorite_Id", "dbo.Favorites", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Favorite_Id", "dbo.Favorites");
            DropIndex("dbo.Products", new[] { "Favorite_Id" });
            DropColumn("dbo.Products", "Favorite_Id");
            DropTable("dbo.Favorites");
        }
    }
}
