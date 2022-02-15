using System;
using System.Collections.Generic;

namespace TypeBestemtClassDemo
{
     
    public class Customer
    {
        public string Navn { get; set; }
        public string By { get; set; }
    }
    public class TypeBestemt<EnType, AndenType>
    {
        public EnType EnTing { get; set; }
        public AndenType AndenTing { get; set; }

        public TypeBestemt(EnType enTing, AndenType andenTing)
        {
            EnTing = enTing;
            AndenTing = andenTing;
        }
        public void Info()
        {
            Console.WriteLine($"\n\t {EnTing} \t {AndenTing}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // List<Customer> //  List<T>
            TypeBestemt<string, string> hilsen = new TypeBestemt<string, string>("Hej", " med jer");
            //hilsen.Info();

            TypeBestemt<int, string> regning = new TypeBestemt<int, string>(5678, "kr. ska betales");
            // regning.Info();

            TypeBestemt<int, string>[] kurser = new TypeBestemt<int, string>[]
                {
                    new TypeBestemt<int, string>(1, "Client Side"),
                    new TypeBestemt<int, string>(2, "Server Side"),
                    new TypeBestemt<int, string>(3, "ASP.NET Core MVC")
                };

            foreach (var k in kurser)
            {
               // k.Info();
            }

            TypeBestemt<int, Customer>[] Kunder = new TypeBestemt<int, Customer>[]
                {
                    new TypeBestemt<int, Customer>(1, new Customer(){ Navn="Ole", By="Valby"}),
                    new TypeBestemt<int, Customer>(2, new Customer(){ Navn="Ove", By="Viby"}),
                    new TypeBestemt<int, Customer>(3, new Customer(){ Navn="Kim", By="Rødby"})
                };

            foreach (var par in Kunder)
            {
                //par.Info();
                //Console.WriteLine($"\n\t Id = {par.EnTing}\t Navn = {par.AndenTing.Navn}\t By = {par.AndenTing.By}");
                
            }

            Dictionary<int, Customer> Kunder2 = new Dictionary<int, Customer>(); // no duplicate Key
            Kunder2.Add(1, new Customer() { Navn = "Mikkel", By = "Tårnby" });
            Kunder2.Add(2, new Customer() { Navn = "Mikkel", By = "Tårnby" });
            Kunder2.Add(3, new Customer() { Navn = "Mikkel", By = "Tårnby" });
            foreach (var par in Kunder2)
            {
                
              //  Console.WriteLine($"\n\t Id = {par.Key}\t Navn = {par.Value.Navn}\t By = {par.Value.By}");

            }

            //Console.WriteLine("\n\t Capacity " + Kunder2.EnsureCapacity(100) );
            //----------------------------------------------------------------------------------
            MyPartialClass mpc = new MyPartialClass();
            mpc.MethodInPartOne();
            mpc.MethodInPartTwo();
            Console.ReadKey();
        }
    }
    //-----------------------------------------------------------------------------------------
    public partial class MyPartialClass
    {
        public void MethodInPartOne()
        {
            Console.WriteLine("\n\t Method In Part One");
        }
    }

    public partial class MyPartialClass
    {
        public void MethodInPartTwo()
        {
            Console.WriteLine("\n\t Method In Part Two");
        }
    }
}
