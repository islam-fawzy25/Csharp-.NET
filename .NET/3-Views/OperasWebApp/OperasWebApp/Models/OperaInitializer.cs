using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OperasWebApp.Models
{
    public class OperaInitializer : CreateDatabaseIfNotExists<OperasDB>
    {
        protected override void Seed(OperasDB context)
        {
            base.Seed(context);
            var operasList = new List<Opera>
            { 
                new Opera{ Title= "Norma", Year=1831, Composer="Vincenzo"},
                 new Opera{ Title= "Rigoletto", Year=1851, Composer="Verdi"},
                  new Opera{ Title= "Tosca", Year=1900, Composer="Puccini"},
                   new Opera{ Title= "Turandot", Year=1926, Composer="Puccini"}
            };
            operasList.ForEach(op => context.Operas.Add(op));
            context.SaveChanges();  // commit
        }
    }
}