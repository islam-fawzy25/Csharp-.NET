using System;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();  // punkt. 1
            Console.WriteLine("\n------------------Employee type -- Full time Emp-----------------");
            //Employee fe = new FullTimeEmployee();  // animal an = new Cat();  Cat myCat = new Cat();
            //fe.FirstName = "Ole";
            //fe.LastName = "Olsen";
            //fe.AnnualSalary = 400000;  // its late now
            Employee fe = new FullTimeEmployee() {FirstName="Ole", LastName="Olsen", AnnualSalary = 444440 };
            Console.WriteLine($"\n\tName = {fe.FullName()}\t Salary = {fe.MonthlySalary()}");
            //fe.FullTimeEmpPersonalMethod(); you are emp type not fulltime emp type

            Console.WriteLine("\n------------------FullTimeEmployee type -- Full time Emp-----------------");
            FullTimeEmployee flte = new FullTimeEmployee() { FirstName = "Jens", LastName = "Jensen", AnnualSalary = 444440 };
            Console.WriteLine($"\n\tName = {flte.FullName()}\t Salary = {flte.MonthlySalary()}");
            flte.FullTimeEmpPersonalMethod();

            Console.WriteLine("\n------------------Employee type -- Part time Emp-----------------");
            Employee pe = new PartTimeEmployee() { FirstName = "Kim", LastName = "Iversen", HourlyPay=250, Hours =105};
            Console.WriteLine($"\n\tName = {pe.FullName()}\t Salary = {pe.MonthlySalary()}");
            
        }
    }
}
