using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack s = new Stack();
            //s.Push(33); s.Push("X-Box"); s.Push(33.99);
            //s.Pop();
            //foreach (var item in s)
            //{
            //    Console.WriteLine("\n\t"+item);
            //}
            //Console.WriteLine("\n------------Queue----------------"); 
            //Queue q = new Queue();
            //q.Enqueue(55); q.Enqueue("Play-Station"); q.Enqueue(55.99);
            ////q.Dequeue();
            //foreach (var item in q)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}

            //Console.WriteLine("\n------------Type Bestemt----Generic------------");
            //Stack<int> s = new Stack<int>();
            //s.Push(99); //s.Push("text");

            //Queue<string> byer = new Queue<string>();  // List<TLog>
            //byer.Enqueue("Valby");  //byer.Enqueue(55);

            //Stack<object> s2 = new Stack<object>();
            //s2.Push(333); s2.Push("text"); s2.Push(333);
            //foreach (var item in s2)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}

            //----------HashSet------ Unique values------------

            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();
            for (int i = 0; i < 11; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }

            //ForeachMethod(evenNumbers);
            //Console.WriteLine("\n----------------------------------\n");
            //ForeachMethod(oddNumbers);
            //HashSet<int> numbers =new HashSet<int>(evenNumbers);
            //Console.WriteLine("\n---------------Union with------------------\n");
            //numbers.UnionWith(oddNumbers);
            //ForeachMethod(numbers);

            //HashSet<string> byer1 = new HashSet<string>() { "Valby", "Viby", "Tårnby", "Rødby" };
            //HashSet<string> byer2 = new HashSet<string>() { "Roskilde", "Viby", "Brøndby", "Rødby" };
            ////byer.UnionWith(byer2);
            ////ForeachMethodString(byer);
            //ForeachMethod(new HashSet<object>(byer1));
            //Console.WriteLine("\n-------------------\n");
            //byer1.IntersectWith(byer2);
            //ForeachMethod(new HashSet<object>(byer1));

            //Console.WriteLine("\n-------------------\n");
            //byer1.ExceptWith(byer2);
            //ForeachMethod(new HashSet<object>(byer1));

            //------------------------------------------------
            HashSet<string> byer = new HashSet<string>();
            HashSet<string> byer1 = new HashSet<string>() { "Valby", "Viby", "Tårnby", "Rødby" };
            HashSet<string> byer2 = new HashSet<string>() { "Roskilde", "Viby", "Brøndby", "Rødby" };

            showForEachValues("byer1", byer1);
            showForEachValues("byer2", byer2);
            byer.UnionWith(byer1);
            byer.UnionWith(byer2);
            showForEachValues("-------byer - UnionWith----", byer);

            byer.Clear();
            byer.UnionWith(byer1);
            byer.IntersectWith(byer2);
            showForEachValues("----byer - IntersectWith----", byer);

            byer.Clear();
            byer.UnionWith(byer1);
            byer.ExceptWith(byer2);
            showForEachValues("---byer - ExceptWith---", byer);

            //-------------------------------------

            Console.ReadKey();
        }

        private static void ForeachMethodString(HashSet<string> byer)
        {
            foreach (var item in byer)
            {
                Console.WriteLine("\n\t" + item);
            }
        }

        private static void ForeachMethod(HashSet<object> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("\n\t" + item);
            }
        }
      
        //---------------------------------------

        private static void showForEachValues(string listName, HashSet<int> collection)
        {
            Console.WriteLine($"\n\t *** List: {listName}");
            foreach (var item in collection) Console.WriteLine($"\n\t\t item = {item}");
        }

        private static void showForEachValues(string listName, HashSet<string> collection)
        {
            Console.WriteLine($"\n\t *** List: {listName}");
            foreach (var item in collection) Console.WriteLine($"\n\t\t item = {item}");
        }

    }
}
