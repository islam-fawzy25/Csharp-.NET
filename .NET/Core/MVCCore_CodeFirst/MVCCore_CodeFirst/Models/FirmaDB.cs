using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCore_CodeFirst.Models
{
    public class FirmaDB : DbContext
    {
        public FirmaDB(DbContextOptions<FirmaDB> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
