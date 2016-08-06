namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_product : DbMigration
    {
        public override void Up()
        {
            AlterColumn("stock.Product", "name", c => c.String(maxLength: 255));
            AlterColumn("stock.Product", "createdBy", c => c.String(maxLength: 10));
            AlterColumn("stock.Product", "updatedBy", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("stock.Product", "updatedBy", c => c.String());
            AlterColumn("stock.Product", "createdBy", c => c.String());
            AlterColumn("stock.Product", "name", c => c.String());
        }
    }
}
