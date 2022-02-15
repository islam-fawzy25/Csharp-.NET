using System;

namespace CoreFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n\tHej venner!");
            int x, y, z; // int x; int y; int z;
            string Navn;
            Console.WriteLine("\n\t Please enter your name");
            Console.Write("\t");
            Navn = Console.ReadLine();
            //Console.WriteLine("\n\t Hej\t"+ Navn);

            Console.WriteLine("\n\t Please enter a number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\t Please enter another number");
            y = int.Parse(Console.ReadLine());
            z = x + y;
            //---1----
            Console.WriteLine("\n\t Hej\t" + Navn + "\t x = "+x + "\t y = "+ y + "\t x+y = "+z);

            //---2----
            Console.WriteLine("\n\t Hej\t {0}\t x = {1}\t y = {2}\t x + y = {3}", Navn, x, y, z);

            //---3----
            Console.WriteLine($"\n\t Hej\t {Navn}\t x = {x}\t y = {y}\t x + y = {z}");

            Console.ReadKey();
        }
    }
}
