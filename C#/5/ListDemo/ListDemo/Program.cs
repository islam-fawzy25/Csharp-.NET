using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------- Array  vs  List-------
            int[] A = new int[2];
            A[0] = 34; A[1] = 88; // A[2] = 55;   runtime error
            foreach (var item in A)
            {
                //Console.WriteLine("\n\t"+item);
            }
            List<int> lst = new List<int>(2);
            lst.Add(33); lst.Add(66); lst.Add(34); lst.Add(66);

            List<int> lst2 = new List<int>();
            //Console.WriteLine(" intial Capacity = "+lst2.Capacity);
            //lst2.Add(22);
            Console.WriteLine($"Count = {lst2.Count}\t intial Capacity = {lst2.Capacity} ");
            for (int i = 1; i < 34; i++)
            {
                Console.WriteLine("-----------------------------------\n");
                lst2.Add(i);
                Console.WriteLine($" Count = {lst2.Count}\t Capacity = {lst2.Capacity} ");
            }
            lst2.TrimExcess();
            Console.WriteLine($"after trim --  Count = {lst2.Count}\t Capacity = {lst2.Capacity} ");
            foreach (var item in lst)
            {
               // Console.WriteLine("\n\t"+item);
            }

            Console.ReadKey();
        }
    }
}
