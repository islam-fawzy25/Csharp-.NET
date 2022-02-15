using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCore_Migrations.Models
{
    public class SalesDB : DbContext
    {
        public SalesDB(DbContextOptions<SalesDB> options):base(options)
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CId = 3, Name = "Ole Olsen" }
                );
            modelBuilder.Entity<Product>().HasData(
               new Product { PId = 1, Name = "TV", Price =5555 }
               );
            modelBuilder.Entity<Order>().HasData(
               new Order { OId = 1, CId = 3, PId = 1, Qty = 2, OrderDate = DateTime.Now } //new DateTime(2021, 10, 27) }
               );
        }
    }
}
