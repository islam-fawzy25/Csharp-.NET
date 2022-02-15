using System;
using System.Collections.Generic;

namespace BuiltInDelegatesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Func-----------input ------ output--------------
            Func<int, int> fd = f => f * f;
            //Console.WriteLine("\n\t"+ fd(5));

            Func<int, string> fd2 = f => (f * f).ToString();
            //Console.WriteLine("\n\t" + fd2(5));

            //-------Action---- Void ---- input --- no output-----------

            Action<int> MyAction = doIt => Console.WriteLine("\n\t"+doIt);
            //MyAction(5);

            //------------Predicate ---------boolean -- returns true/false------------
            Predicate<int> JegHarStemmeret = alder => alder >= 18;
            //Console.WriteLine("\n\t jeg kan stemme \t" + JegHarStemmeret(25));

            Predicate<string> lessThan6 = s => s.Length < 6;
            string myString = "Hej";
            //Console.WriteLine("\n\t Less than 6 ?  \t" + lessThan6(myString));

            List<string> byer = new List<string>();
            byer.Add("København"); byer.Add("Valby"); byer.Add("Oslo");
            byer.Add("Lahore"); byer.Add("Malmo"); byer.Add("Kazan");
            byer.Add("Konya"); byer.Add("Berlin"); byer.Add("UlaanBataar");

            //Console.WriteLine("\n\t Less than 6 ?  \t" + byer.Find(lessThan6));
            //Console.WriteLine("\n\t Less than 6 ?  \t" + byer.FindAll(lessThan6));
            
            foreach (var item in byer)
            {
                Console.WriteLine("\n\t" + item);
            }
            Console.WriteLine("-------Cities with Short Names--------------");
            foreach (var by in byer.FindAll(lessThan6))
            {
                Console.WriteLine("\n\t " + by);
            }
            List<string> SmallCityNames = byer.FindAll(lessThan6);
            Console.WriteLine("---------------------");
            foreach (var by in SmallCityNames)
            {
                Console.WriteLine("\n\t " + by);
            }

            Console.ReadKey();
        }
    }
}
