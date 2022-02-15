using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownListDemo.Models
{
    public class KundeDB :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}