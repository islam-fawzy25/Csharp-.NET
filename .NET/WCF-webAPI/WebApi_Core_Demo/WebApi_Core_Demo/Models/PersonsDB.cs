using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Core_Demo.Models
{
    public class PersonsDB : DbContext
    {
        public PersonsDB(DbContextOptions<PersonsDB> options):base(options)
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
    }
}
