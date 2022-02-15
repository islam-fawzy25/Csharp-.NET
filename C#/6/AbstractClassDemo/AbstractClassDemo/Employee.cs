using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    /*
     * 1- You can't create object of an abstract class
     * 2- If at least one of the members of a class is abstract, class becomes abstract
     * 3- Abstract class can have both abstract and non-abstract methods
     * 4- Abstract Methods can't have implimentation
     * 5- Derived class must impliment abstract methods 
     */
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract double MonthlySalary();
        
    }
}
