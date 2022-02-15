using System;

namespace ConstructorEX
{
    public class Customer
    {
        int AcNo; string Name; double Balance;
        /*
         1- Every class have a constructor - invisible? default / parameterless
         2- Constructor is a special method
         3- Same name as class name
         4- no return
         5- overloading allowed
         6- It is invoked implicitly when you create a new instance/object of class
         7- You can't invoke it explicitly
         */
        public Customer()
        {
            Console.WriteLine("\n\t default / parameterless Constructor");
        }

        public Customer(int a, string n, double b)
        {
            AcNo = a;
            Name = n;
            Balance = b;
        }
        public void Saldo()
        {
            Console.WriteLine($" Acc = {AcNo}\t Name = {Name}\t Balance = {Balance}");
        }
        public void Deposite(double amount)
        {
            Balance += amount;  // Balance = Balance + amount ;
        }
        public void withdraw(double amount)
        {
            Balance -= amount;  
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();  // punkt 6.
                                               //c.Customer();  punkt 7.

            Customer c2 = new Customer(111, "Ole", 8888);
            c2.Saldo();

            Console.WriteLine("\n\t ------------- After Deposit-----------");
            c2.Deposite(5555);
            c2.Saldo();

            Console.WriteLine("\n\t ------------- After withdraw-----------");
            c2.withdraw(10000);
            c2.Saldo();

            Console.ReadKey();
        }
    }
}
