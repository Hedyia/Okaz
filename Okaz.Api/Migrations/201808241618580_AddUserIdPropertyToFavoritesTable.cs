namespace Okaz.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdPropertyToFavoritesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favorites", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Favorites", "UserId");
        }
    }
}
