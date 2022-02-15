using System;

namespace ThisKeyWordEx
{
    public class Customer
    {
        int ACNo; string Name; double Balance; int Phone;
        public Customer()
        {
            Console.WriteLine("\n\t Parameterless Constructor");
        }
        public Customer(int ACNo, string Name, double Balance):this()
        {
            this.ACNo = ACNo;
            this.Name = Name;
            this.Balance = Balance;
        }
        public Customer(int ACNo, string Name, double Balance, int Phone): this(ACNo,Name,Balance)
        {
            //this.ACNo = ACNo;
            //this.Name = Name;
            //this.Balance = Balance;
            this.Phone = Phone;
        }
        public void Saldo()
        {
            Console.WriteLine($"\n\t  Acc = {ACNo}\t Name = {Name}\t Balance  = {Balance}\t Phone  = {Phone}");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer(111, "Ole Olsen", 56456);
            //c.Saldo();
            Customer c2 = new Customer(111, "Ib Ibsen", 56456, 11111111);
            c2.Saldo();

            Console.ReadKey();
        }
    }
}
