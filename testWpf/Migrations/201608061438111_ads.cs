namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ads : DbMigration
    {
        public override void Up()
        {
            DropIndex("stock.Product", new[] { "name" });
            AlterColumn("stock.Product", "name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("stock.Product", "createdBy", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("stock.Product", "updatedBy", c => c.String(nullable: false, maxLength: 10, unicode: false));
            CreateIndex("stock.Product", "name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("stock.Product", new[] { "name" });
            AlterColumn("stock.Product", "updatedBy", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("stock.Product", "createdBy", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("stock.Product", "name", c => c.String(maxLength: 255));
            CreateIndex("stock.Product", "name", unique: true);
        }
    }
}
