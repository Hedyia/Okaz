namespace Okaz.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCatalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategotyId = c.Int(nullable: false),
                        ImgUrl = c.String(),
                        Price = c.Int(nullable: false),
                        InOffer = c.Boolean(nullable: false),
                        Category_Id = c.Int(),
                        Brand_Id = c.Int(),
                        Order_Id = c.Int(),
                        Vendor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Brand_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LaptopSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        ProcessorType = c.String(),
                        USB = c.String(),
                        DisplaySize = c.String(),
                        MemoryCardReader = c.Boolean(nullable: false),
                        NumberOfProcessorCore = c.String(),
                        VideoControllerManufacturer = c.String(),
                        MemoryTechnology = c.String(),
                        ProcessorSpeed = c.String(),
                        LaptopFamily = c.String(),
                        Usage = c.String(),
                        OpticalDriveType = c.String(),
                        TochScreen = c.Boolean(nullable: false),
                        ModelNumber = c.String(),
                        KeyboardLanguages = c.String(),
                        ItemEAN = c.String(),
                        Color = c.String(),
                        OS = c.String(),
                        HardDiskCapacity = c.String(),
                        RamSize = c.String(),
                        ProcessorFamily = c.String(),
                        GraphicsCardCapacity = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.MobileSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        OS = c.String(),
                        StorageCapacity = c.String(),
                        NumberOfSIM = c.String(),
                        MobilePhoneType = c.String(),
                        CellularNetworkTechnology = c.String(),
                        ChipsetManufacturer = c.String(),
                        ModelNumber = c.String(),
                        EAN13 = c.String(),
                        BatteryCapacityInMah = c.String(),
                        RearCameraResolution = c.String(),
                        Audio = c.Boolean(nullable: false),
                        DisplaySize = c.String(),
                        NFC = c.Boolean(nullable: false),
                        FrontFlash = c.Boolean(nullable: false),
                        Color = c.String(),
                        FastCharge = c.Boolean(nullable: false),
                        OSVersion = c.String(),
                        MemoryRAM = c.String(),
                        ProcessorType = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        ShoppingCart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.ShoppingCart_Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.ShoppingCartItems", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.MobileSpecifications", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.LaptopSpecifications", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.ShoppingCartItems", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.ShoppingCartItems", new[] { "Product_Id" });
            DropIndex("dbo.MobileSpecifications", new[] { "Product_Id" });
            DropIndex("dbo.LaptopSpecifications", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Vendor_Id" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropIndex("dbo.Products", new[] { "Brand_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropTable("dbo.Vendors");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.ShoppingCartItems");
            DropTable("dbo.Orders");
            DropTable("dbo.MobileSpecifications");
            DropTable("dbo.LaptopSpecifications");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
