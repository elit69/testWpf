namespace testWpf.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using testWpf.model;
    using testWpf.model.entity;

    internal sealed class Configuration : DbMigrationsConfiguration<testWpf.model.CoffeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testWpf.model.CoffeeContext context)
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE stock.Product");
            context.Products.AddOrUpdate(
                new Product { name = "Ice Latte", subCategoryId = 1, priceKHR = 12000, priceUSD = 3, isPackage = false, isDeleted = false, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" },
                new Product { name = "Capuchino", subCategoryId = 1, priceKHR = 16000, priceUSD = 4, isPackage = false, isDeleted = false, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" },
                new Product { name = "Breakfast", subCategoryId = 1, priceKHR = 20000, priceUSD = 5, isPackage = true, isDeleted = false, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" },
                new Product { name = "coasdf", subCategoryId = 1, priceKHR = 20000, priceUSD = 5, isPackage = true, isDeleted = true, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" }
            );
            
        }
    }
}
