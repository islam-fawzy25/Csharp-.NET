using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    public class ForLoopClass
    {
        public void ForLoopMethod()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("\n\t --> " + i);
            }
        }

        public void ForLoopMethod(int n)  // method overloading
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\t --> " + i);
            }
        }
        public static void StaticForLoopMethod(int n)  
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\t --> " + i);
            }
        }
    }
}
