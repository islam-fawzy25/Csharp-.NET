using InheritenceDemo;
using System;

namespace InhetanceDemoAndenProject
{
    public class Datter : Person
    {
        public void DatterInfoMethod()
        {
            x = 8;
            pt = 6;
            //i = 7;  visible within name space
            pti = 7;
            //prpt = 3;  not visible

            Console.WriteLine("\n\t Datters Info method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Datter d = new Datter();
            d.FarFarsInfoMethod();
            d.FarsInfoMethod();
            d.PersonsInfoMethod();
            d.DatterInfoMethod();
        }
    }
}
