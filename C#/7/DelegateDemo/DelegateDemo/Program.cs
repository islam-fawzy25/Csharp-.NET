using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateDemo
{
    public delegate void DelegateTest(string besked); // can have return bool, int, string
    public delegate int CalculationDelegate(int a);
    public delegate bool LønforhøjelseDelegate(Medarbejder m);
    class Program
    {  // propfull
        private int dronning;
        public int Vagt
        {
            get { return dronning; }
            set { dronning = value; }
        }
        public int Politi { get; set; }

        static void Show(string message)
        {
            Console.WriteLine("\n\t Show method "+ message);
        }
        static void Info(string message)
        {
            Console.WriteLine("\n\t Info method " + message);
        }
        static void Vise(string message)
        {
            Console.WriteLine("\n\t Vise method " + message);
        }
        static void Print(int message)  // <-- int parameter
        {
            Console.WriteLine("\n\t Print method " + message);
        }
        static void Display(string message)
        {
            Console.WriteLine("\n\t Display method " + message);
        }

        static int Kvadrat(int x)
        {
            return x * x;
        }
        static int Kube(int x)
        {
            return x * x * x;
        }
        static void Main(string[] args)
        {
          
            //DelegateTest dt = new DelegateTest(Show);
            //dt += new DelegateTest(Info);

            DelegateTest dt;
            dt = Show;
            dt += Info;
            dt += Vise;
            //dt += Print;  signature doesn't match
            dt += Display;
            //dt(" represented by dt delegate");  // 
            Console.WriteLine("-----------------------------------------------------");
            dt -= Display;
            //dt(" represented by dt delegate but not Display method");  //

            foreach (Delegate d in dt.GetInvocationList())
            {
               // Console.WriteLine("\n\t"+ d.Method.Name);
            }

            CalculationDelegate cd = new CalculationDelegate(Kvadrat);
            cd += Kube;
            //Console.WriteLine("\n\t"+ cd(5) + cd.Invoke(5)); shows last value
            foreach (Delegate d in cd.GetInvocationList())
            {
               //  Console.WriteLine($"\n\t {d.Method.Name}\t return type = {d.Method.ReturnType}");
            }
            //Console.WriteLine($"\n\t {cd.GetInvocationList()[0].DynamicInvoke(5)}\t " +
            //    $"{cd.GetInvocationList()[1].DynamicInvoke(6)}");
            // ----------alternative----------------------
            IEnumerable<int> result = cd.GetInvocationList().Select(k => (int)k.DynamicInvoke(5));
            foreach (var item in result)
            {
               // Console.WriteLine("\n\t"+item);
            }

            //---------------------------Anonymous function----------
            CalculationDelegate cd3 = new CalculationDelegate(delegate (int x) { return x * x; });
           // Console.WriteLine("\n\t" +cd3(9));

            //-----------Lambda expression------------------
            CalculationDelegate cd4 = x =>  x * x; // x ikke? ja! gang x med x
                                                   // Console.WriteLine("\n\t" + cd4(9));

            //------------------------------------------------------------------------------
            List<Medarbejder> MaList = new List<Medarbejder>();
            MaList.Add(new Medarbejder() { Id = 1, Navn = "Ole", Erfaring =3, Løn = 27000 });
            MaList.Add(new Medarbejder() { Id = 2, Navn = "Ove", Erfaring = 6, Løn = 23000 });
            MaList.Add(new Medarbejder() { Id = 3, Navn = "Kim", Erfaring = 8, Løn = 22200 });
            MaList.Add(new Medarbejder() { Id = 4, Navn = "Kurt", Erfaring = 2, Løn = 23330 });
            MaList.Add(new Medarbejder() { Id = 5, Navn = "Per", Erfaring = 1, Løn = 33333 });
            MaList.Add(new Medarbejder() { Id = 6, Navn = "Mia", Erfaring = 6, Løn = 29000 });
            MaList.Add(new Medarbejder() { Id = 7, Navn = "Ali", Erfaring = 5, Løn = 21000 });
            MaList.Add(new Medarbejder() { Id = 8, Navn = "Ahmad", Erfaring = 9, Løn = 26500 });
            MaList.Add(new Medarbejder() { Id = 9, Navn = "Ib", Erfaring = 7, Løn = 23000 });
            MaList.Add(new Medarbejder() { Id = 10, Navn = "Sue", Erfaring = 1, Løn = 31000 });
            //1
            //Medarbejder.LønForHøjelse(MaList);  
            //2
            //LønforhøjelseDelegate dele = new LønforhøjelseDelegate(Berettiget);
            //Medarbejder.LønForHøjelse(MaList, dele);
            //3 
            //LønforhøjelseDelegate dele = new LønforhøjelseDelegate(m =>m.Erfaring>5);
            //Medarbejder.LønForHøjelse(MaList, dele);
            //4
            LønforhøjelseDelegate dele = new LønforhøjelseDelegate(m => m.Løn < 26000);
            Medarbejder.LønForHøjelse(MaList, dele);
            Console.ReadKey();
        }
        public static bool Berettiget(Medarbejder m)
        {
            //if (m.Erfaring>5)
                if (m.Løn < 25000)
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
