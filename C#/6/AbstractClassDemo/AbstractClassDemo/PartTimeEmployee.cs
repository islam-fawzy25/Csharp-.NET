using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class PartTimeEmployee:Employee
    {
        public double HourlyPay { get; set; }
        public double Hours { get; set; }

        public override double MonthlySalary()
        {
            return HourlyPay * Hours;
        }
    }
}
