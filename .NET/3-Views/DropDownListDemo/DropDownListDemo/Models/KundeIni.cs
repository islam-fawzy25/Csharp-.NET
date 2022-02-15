using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DropDownListDemo.Models
{
    public class KundeIni : CreateDatabaseIfNotExists<KundeDB>
    {
        protected override void Seed(KundeDB db)
        {
            base.Seed(db);
            var KundeList = new List<Customer>
            { 
                new Customer{Name="Ole", CountryId = 1 },
                new Customer{Name="Per", CountryId = 2 },
                new Customer{Name="Hammad", CountryId = 4 },
                new Customer{Name="Kim", CountryId = 3 },
                new Customer{Name="Jens", CountryId = 1 }
            };
            KundeList.ForEach(k => db.Customers.Add(k));
            db.SaveChanges();

            var CountryList = new List<Country>
            { 
                new Country{CountryName = "Danmark"},
                new Country{CountryName = "Sverige"},
                new Country{CountryName = "Norge"},
                new Country{CountryName = "Finland"}
            };
            CountryList.ForEach(c => db.Countries.Add(c));
            db.SaveChanges();
        }
    }
}