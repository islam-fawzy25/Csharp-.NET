using System;

namespace ValueTypeVsReferenceType
{
    class Customer
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int x = 5;
            int z = x;
            Console.WriteLine($"\n\t x = {x}\t z = {z}");
            z = 7;
            Console.WriteLine($"\n\t x = {x}\t z = {z}");

            Customer c1 = new Customer();
            c1.Id = 1; c1.Name = "Ole Olsen";

            Customer c2 = new Customer();
            c2.Id = 1; c2.Name = "Ole Olsen";

            //Console.WriteLine($"\n\t c1.Name = {c1.Name}\t c2.Name = {c2.Name}");
            //c2.Name = "Ib Olsen";
            //Console.WriteLine($"\n\t c1.Name = {c1.Name}\t c2.Name = {c2.Name}");

            int a = 5;
            int c = a;
            Customer c3 = c1;
            if (c1 == c3)
            {
                Console.WriteLine($"\n\t yes equal- c1.Name = {c1.Name}\t c3.Name = {c3.Name}");
            }
           
            else
            {
                Console.WriteLine($"\n\t NOT equal- c1.Name = {c1.Name}\t c3.Name = {c3.Name}");
            }
            c3.Name = "Peter Petersen";
            Console.WriteLine($"\n\t yes equal- c1.Name = {c1.Name}\t c3.Name = {c3.Name}");

            if (c1 == c2)
            {
                Console.WriteLine($"\n\t yes equal- c1.Name = {c1.Name}\t c2.Name = {c2.Name}");
            }
            else
            {
                Console.WriteLine($"\n\t NOT equal- c1.Name = {c1.Name}\t c2.Name = {c2.Name}");
            }

            Console.ReadKey();
        }
    }
}
