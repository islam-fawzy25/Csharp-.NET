using System;

namespace PropertyDemo
{
    class Person
    {
        //private int dronning;
        //public int Vagt
        //{ 
        //    get { return dronning; }
        //    set { dronning = value; }                
        //}
        //public int MyProperty { get; set; }   // prop
        //private int x;
        //public int X { get => x; set => x = value; }

        private int id;   //propfull
        public int ID
        {
            get { return id; }
            set {
                    if (value <0)
                    {
                        Console.WriteLine("\n\t No -Ve Values Please");
                    }
                    else
                    {
                        id = value;
                    }                
                }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.ID = -77;
            p.ID = 77;
            Console.WriteLine("\n\t id = " + p.ID);
        }
    }
}
