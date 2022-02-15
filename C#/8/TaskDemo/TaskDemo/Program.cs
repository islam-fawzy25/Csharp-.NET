using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void ActionMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\t--"+i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            //ThreadPool.QueueUserWorkItem(
            //    (d) =>
            //    {
            //        Console.WriteLine("\n\td Item in thread pool");
            //    }
            //    );

            //Thread.Sleep(3000);

            //--------------------------Tasks---------------
            //---1
            // Task T1 = new Task(ActionMethod);
            // start() is used if you define Task this way only
            //T1.Start(); // by default it runs in background
            //T1.Wait(); // join() in Thread but wait() in Task
            // Console.WriteLine($"\n\t T1 is launched main Thread Id = {Thread.CurrentThread.ManagedThreadId}");

            //---2
            //Task T2 = Task.Factory.StartNew(ActionMethod);
            //T2.Wait();

            //----3
            //Task T3 = Task.Run(ActionMethod);
            //T3.Wait();

            //----------Task with return Type-----------------
            //Task<int> T4 = Task.Run(
            //         ()=> { return 9; }
            //    );
            //Console.WriteLine("\n\t T4 result = " + T4.Result);
          

            //-------------Continue with ----------------------------

            Task<int> T5 = Task.Run(
                     () => { return 9; }
                ).ContinueWith(
                  (T5Part1) => { return 10 * T5Part1.Result;  }
                ).ContinueWith(
                 (T5Part2) => { return 5 * T5Part2.Result; }
                );
            //T5.ContinueWith(
            T5 = T5.ContinueWith(
               (tidliger) => { return 3 * tidliger.Result; }
                );

            // Console.WriteLine("\n\t T5 result = " + T5.Result);

            //----------------------------completed----- faulted------------

            //Task<int> T6 = Task.Run
            //    (
            //         () => { return 6 ; }
            //    );
            //T6.ContinueWith(
            //         (selv) =>
            //        {
            //            Console.WriteLine("\n\t T6 completed with result = " + selv.Result);
            //        }, TaskContinuationOptions.OnlyOnRanToCompletion
            //    );
            //// drink if thirsty
            //T6.ContinueWith(
            //         (selv) =>
            //         {
            //             Console.WriteLine("\n\t T6 faulted ");
            //         }, TaskContinuationOptions.OnlyOnFaulted
            //    );

            //Console.WriteLine("--- Task, Completed / Faulted");
            //Task<int> t6 = Task.Run(() => { return 6; })
            //    .ContinueWith((value) => { return value.Result - value.Result; })
            //.ContinueWith((value) => { return value.Result / value.Result; })
            //;
            //t6.ContinueWith(
            //    (value) => { Console.WriteLine($"\n\t t6 completed with result = {value.Result}"); }
            //    , TaskContinuationOptions.OnlyOnRanToCompletion
            //);
            //t6.ContinueWith(
            //    (value) => { Console.WriteLine($"\n\t t6 faulted with result = {value.Exception}"); }
            //    , TaskContinuationOptions.OnlyOnFaulted
            //    );

            //-------------waitAll---------------
            //Task[] myTasks = new Task[3];

            //myTasks[0] = Task.Run(
            //     ()=> 
            //     { 
            //         Thread.Sleep(7000);
            //         Console.WriteLine("\n\t myTask[0] finished in 7 sec"); 
            //     }
            //    );

            //myTasks[1] = Task.Run(
            //     () =>
            //     {
            //         Thread.Sleep(5000);
            //         Console.WriteLine("\n\t myTask[1] finished in 5 sec");
            //     }
            //    );
            //myTasks[2] = Task.Run(
            //     () =>
            //     {
            //         Thread.Sleep(3000);
            //         Console.WriteLine("\n\t myTask[2] finished in 3 sec");
            //     }
            //    );
            //Task.WaitAll(myTasks);
            //Task.WaitAny(myTasks);
            //-----------------------------WaitAny------------------------------
            Task<int>[] tasks = new Task<int>[5];
            tasks[0] = Task.Run(()=> { Thread.Sleep(3000); return 11111; });
            tasks[1] = Task.Run(() => { Thread.Sleep(10000); return 22222;});
            tasks[2] = Task.Run(() => { Thread.Sleep(700); return 33333; });
            tasks[3] = Task.Run(() => { Thread.Sleep(5000); return 44444; });
            tasks[4] = Task.Run(() => { Thread.Sleep(8000); return 55555; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine($"\n\t Task with index = {i} with result = {completedTask.Result} " +
                    $"is completed and removed from array");
                var ListFor2Sec = tasks.ToList();
                ListFor2Sec.RemoveAt(i);
                tasks = ListFor2Sec.ToArray();
            }

            //Console.ReadKey();
        }
    }
}
