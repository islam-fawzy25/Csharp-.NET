using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList lst = new MyLinkedList();
            lst.Add("AAAAAAAAA");
            lst.Add("BBBBBBBBB");
            lst.Add("CCCCCCCCC");
            lst.Add("DDDDDDDDD");
            lst.Add(3, "KKKKKKKKKK");
            lst.Add(300, "MMMMMMMMMM");
            lst.Add(0, "aaaaaaaaaaa");
            lst.VisIConsole();

            //-----------Inbuilt LinkedList---------------

            LinkedList<int> inbuiltList = new LinkedList<int>();
            var node1 = inbuiltList.AddFirst(1111111);
            var node2 = inbuiltList.AddLast(999999999);
            var node3 = inbuiltList.AddBefore(node2 , 8888888 );
            var node4 = inbuiltList.AddAfter(node3, 4444444);

            foreach (var item in inbuiltList)
            {
                Console.WriteLine("\n\t" + item);
            }

            Console.ReadKey();
        }
    }
}
