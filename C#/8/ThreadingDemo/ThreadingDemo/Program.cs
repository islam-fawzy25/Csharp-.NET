using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void MethodOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\t --> " +i);
                Thread.Sleep(1000);
            }
        }
        static void MethodTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\t" + i + " <--");
                Thread.Sleep(1000);
            }
        }
        static void PeramMethod(object x)
        {
            for (int i = 0; i < (int)x; i++)
            {
                Console.WriteLine("\n\t Param Method" + i + " <--");
                Thread.Sleep(1000);
            }
        }
        [ThreadStatic]
        static int x = 0;
        static void Main(string[] args)
        {
            //MethodOne();
            //MethodTwo();
            // Thread trd1 = new Thread(new ThreadStart(MethodOne));
            //Thread trd1 = new Thread(MethodOne);
            //Thread trd2 = new Thread(MethodTwo);
            //trd1.IsBackground = true;
            //trd1.Start();  // by default thread runs in forground
            //trd2.Start();
            //trd1.Join();  // you yourself make main not responding
            //-------------------Parameterized Thread------------------------------------
            //Thread trd3 = new Thread(PeramMethod);
            //trd3.Start(12);

            //-------------Thread Static------------------------------

            Thread trd4 = new Thread(new ThreadStart(
                    () =>
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            x++; // 1 2 
                            Console.WriteLine("\n\t thread-4 ->\t" + x );
                            Thread.Sleep(1000);
                        }
                    }
                ));

            Thread trd5 = new Thread(new ThreadStart(
                    () =>
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            x++; // 1 2 
                            Console.WriteLine("\n\t thread-5 ->\t" + x);
                            Thread.Sleep(1000);
                        }
                    }
                ));
            //trd4.Start();
            //trd5.Start();

            //--------------------------Stopping thread----------------------------
            bool DoNotStop = true;
            Thread trd6 = new Thread(new ThreadStart(
                    () =>
                    {
                        while (DoNotStop)
                        {
                            Console.WriteLine("\n\t thread-6  Don't listen Continue \t" );
                            Thread.Sleep(1000);
                        }
                    }
                ));
            trd6.Start();
            Console.WriteLine("\n\t Main Thread finished");
            Thread.Sleep(6000);
            DoNotStop = false;
            //Console.ReadKey();'

        }

    }
}
