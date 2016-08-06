using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using testWpf.model.entity;

namespace testWpf.model
{
    public class CoffeeContext : DbContext
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
