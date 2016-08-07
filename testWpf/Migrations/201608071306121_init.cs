namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "stock.Product",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 255),
                        subCategoryId = c.Short(nullable: false),
                        priceKHR = c.Decimal(nullable: false, precision: 18, scale: 2),
                        priceUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isPackage = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 10, unicode: false),
                        updatedBy = c.String(nullable: false, maxLength: 10, unicode: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("stock.Product", new[] { "name" });
            DropTable("stock.Product");
        }
    }
}
