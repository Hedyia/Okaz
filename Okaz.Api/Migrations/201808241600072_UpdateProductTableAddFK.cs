namespace Okaz.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductTableAddFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.Products", "Vendor_Id", "dbo.Vendors");
            DropIndex("dbo.Products", new[] { "Brand_Id" });
            DropIndex("dbo.Products", new[] { "Vendor_Id" });
            RenameColumn(table: "dbo.Products", name: "Brand_Id", newName: "BrandId");
            RenameColumn(table: "dbo.Products", name: "Vendor_Id", newName: "VendorId");
            AlterColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "VendorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BrandId");
            CreateIndex("dbo.Products", "VendorId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "VendorId", "dbo.Vendors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "VendorId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            AlterColumn("dbo.Products", "VendorId", c => c.Int());
            AlterColumn("dbo.Products", "BrandId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.Products", name: "BrandId", newName: "Brand_Id");
            CreateIndex("dbo.Products", "Vendor_Id");
            CreateIndex("dbo.Products", "Brand_Id");
            AddForeignKey("dbo.Products", "Vendor_Id", "dbo.Vendors", "Id");
            AddForeignKey("dbo.Products", "Brand_Id", "dbo.Brands", "Id");
        }
    }
}
