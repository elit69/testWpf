namespace testWpf
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CoffeeContext : DbContext
    {
        public CoffeeContext()
            : base("name=CoffeeContext")
        {
        }

        public virtual DbSet<Category> tbCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SubCategory> tbSubCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.subcategoryid)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.price_khr)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.price_usd)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.created_at)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.is_package)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.is_deleted)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.categoryid)
                .IsUnicode(false);
        }
    }
}
