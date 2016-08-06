namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("stock.Product", "createdBy", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("stock.Product", "updatedBy", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("stock.Product", "updatedBy", c => c.String(maxLength: 10));
            AlterColumn("stock.Product", "createdBy", c => c.String(maxLength: 10));
        }
    }
}
