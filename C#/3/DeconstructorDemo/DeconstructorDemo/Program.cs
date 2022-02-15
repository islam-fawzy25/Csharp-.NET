using System;

namespace DeconstructorDemo
{

    class Person
    {
        public Person()
        {
            Console.WriteLine("\n\t Person object is created");
        }
        ~Person()
        {
            Console.WriteLine("\n\t Person object is Destroyed");
        }
    }

    class Customer
    {
        int privateId;
        string privateName;

        public Customer(int Id, string Name)
        {
            privateId = Id;
            privateName = Name;
        }
        public void Deconstruct(out int takeOutId, out string takeOutName)
        {
            takeOutId = privateId;
            takeOutName = privateName;
        }
    }
    class Program
    {
        static void PersonObject()
        {
            Person p = new Person();
        }
        //static int Calc(int a, int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //}

        static (int,int) Calc(int a, int b) //c# 6.0 Tuple class - Tuple<int, int>
        {
            int plus = a + b;
            int gang = a * b;
            return (plus, gang);
        }
        static void Main(string[] args)
        {
            //PersonObject();
            //Person p = new Person(); 
            //GC.Collect();
            //----------------------------
            //var reslt = Calc(7, 8);
            //Console.WriteLine("\n\t plus = " + reslt.Item1);
            //Console.WriteLine("\n\t gang = " + reslt.Item2);
            //(int sum, int multply) = Calc(7,8);
            //var ( sum, multiply) = Calc(7, 8);
            // Console.WriteLine($"\n\t plus = {sum}\t gang = {multiply}" );

            Customer c = new Customer(23, "Ove Iversen");
            //(int IdOut, string NameOut) = c;
            //var(IdOut, NameOut) = c;
            //Console.WriteLine($"\n\t Id = {IdOut}\t Name = {NameOut}");
            var (_, NameOut) = c;
            Console.WriteLine($"\n\t Id not required \t Name = {NameOut}");
            Console.ReadKey();
        }
    }
}
