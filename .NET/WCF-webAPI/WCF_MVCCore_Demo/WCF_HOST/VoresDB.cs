using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WCF_HOST
{
    public partial class VoresDB : DbContext
    {
        public VoresDB()
            : base("name=VoresDB")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.pUnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
