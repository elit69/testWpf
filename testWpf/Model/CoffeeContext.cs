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

        public virtual DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
