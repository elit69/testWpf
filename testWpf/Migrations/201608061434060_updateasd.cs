namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateasd : DbMigration
    {
        public override void Up()
        {
            CreateIndex("stock.Product", "name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("stock.Product", new[] { "name" });
        }
    }
}
