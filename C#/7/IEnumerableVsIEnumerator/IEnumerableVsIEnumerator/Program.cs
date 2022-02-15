using System;
using System.Collections.Generic;

namespace IEnumerableVsIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(11); lst.Add(22); lst.Add(33); lst.Add(44); lst.Add(55);
            lst.Add(66); lst.Add(77); lst.Add(88); lst.Add(99);

            Console.WriteLine("\n-------------------IEnumerable-----------------\n");

            IEnumerable<int> enb = (IEnumerable<int>)lst;
            //foreach (var item in enb)
            //{
            //    Console.WriteLine("\n\t"+item);
            //}
            ShowUpto55(enb);
            Console.WriteLine("\n-------------------IEnumerator-----------------\n");
            IEnumerator<int> ent = lst.GetEnumerator();
            //foreach (var item in ent){}  can't use
            //while (ent.MoveNext())
            //{
            //    Console.WriteLine("\n\t" + ent.Current);
            //}
            ShowUpto55(ent);
        }

        private static void ShowUpto55(IEnumerator<int> ent)
        {
            while (ent.MoveNext())
            {
                if (ent.Current>55)
                {
                    Console.WriteLine("\n\t --> value Out --> " + ent.Current);
                    ShowLastValues(ent);
                }
                else
                {
                    Console.WriteLine("\n\t " + ent.Current + " <---- ");
                }
            }
        }

        private static void ShowLastValues(IEnumerator<int> ent)
        {
            Console.WriteLine("\n\t --> " + ent.Current);
            while (ent.MoveNext())
            {
                Console.WriteLine("\n\t --> " + ent.Current );
            }
        }

        private static void ShowUpto55(IEnumerable<int> enb)
        {
            foreach (var item in enb)
            {
                if (item > 55)
                {
                    Console.WriteLine("\n\t --> value Out --> "+item);
                    ShowLastValues(enb);
                }
                else
                {
                    Console.WriteLine("\n\t " + item + " <---- ");
                }
            }
        }

        private static void ShowLastValues(IEnumerable<int> enb)
        {
            foreach (var item in enb)
            {
                Console.WriteLine("\n\t" + item);
            }
        }
    }
}
