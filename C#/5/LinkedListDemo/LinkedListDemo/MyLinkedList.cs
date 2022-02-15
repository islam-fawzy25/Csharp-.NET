using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class MyLinkedList
    {
        Node head;
        int count;
        public int Count { get => count;  }
        public bool Empty { get => count==0; }
        public MyLinkedList()
        {
            head = null;
            count = 0;
        }
        public void Add(int index, object data)
        {
            if (index <0)
            {
                //throw new ArgumentOutOfRangeException("er du sikkert? index =" + index);
                throw new IndexOutOfRangeException("er du sikkert? index =" + index);
            }
            if (index > count)
            {
                index = count;
            }
            Node Current = head;
            if (Empty || index==0)
            {
                head = new Node(data, head);  // x = x + 1 ;
            }
            else
            {
                for (int i = 0; i < index-1; i++) // 0 , 1, 2 
                {
                    Current = Current.Next;
                }
                Current.Next = new Node(data, Current.Next);  // x = x + 1
            }
            count++; 
        }
        public void Add(object data)
        {
            Add(count, data);
        }
        
        public void VisIConsole()
        {
            Node Current = head;
            while (Current !=null)
            {
                Console.WriteLine("\n\t"+Current.Data);
                Current = Current.Next;
            }
        }
    }
}
