using System;

namespace ClassEx
{
    public class Customer // user defined type
    {
        int AcNo; string Name; double Balance;  // state
        //behaviour
        public void CreateCustomer(int a, string n, double b)
        {
            AcNo = a;
            Name = n;
            Balance = b;
        }
        public void Saldo()
        {
            Console.WriteLine($"Acc = {AcNo}\t Name = {Name}\t  Balance = {Balance}");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("\n\t Static Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;  string d = "fdgdg";

            Customer c = new Customer();
            //c.CreateCustomer(111, "Ole", 45345);
            //c.Saldo();
            //c.CreateCustomer(111, "Ole", 465345);
            //c.Saldo();
            //c.StaticMethod();
            //Customer.StaticMethod();
            //Console Cs = new Console();
            //Cs.ReadKey();

            ForLoopClass fl = new ForLoopClass();
            fl.ForLoopMethod();
            Console.WriteLine("-------------------------------------");
            fl.ForLoopMethod(15);
            Console.WriteLine("-------------------------------------");
            ForLoopClass.StaticForLoopMethod(12);

            Console.ReadKey();
        }
    }
}
