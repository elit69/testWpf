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
                        name = c.String(),
                        subCategoryId = c.Short(nullable: false),
                        priceKHR = c.Decimal(nullable: false, precision: 18, scale: 2),
                        priceUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isPackage = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        updatedBy = c.String(),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("stock.Product");
        }
    }
}
