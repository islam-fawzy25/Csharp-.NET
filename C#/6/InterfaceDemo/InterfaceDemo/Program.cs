using System;

namespace InterfaceDemo
{
    /*
     * 1- upto c#7.0, 100 % abstract but from c#8.0 default implimentation of methods is allowed
     * 2- no need to write keyword 'abstract'
     * 3- Instance data -> variables/fields/attributes are not allowed but properties are allowed
     * 4- Interface name starts with 'I'
     * 5- You can't create objects
     */
    interface IA
    {
        //int x;
        //public int Id { get; set; }
        void ShowIA();   // derived class must impliment this method
        public void MethodWithDefaultImplementationInIA()  // you choose to ipmlement or Not to ipmlement
        {
            Console.WriteLine("\n\t Method With Default Imlimentation In IA");
        }
    }
    interface IB : IA
    {
        void ShowIB();
    }
    public class C : IA
    {
        public void ShowIA()
        {
            Console.WriteLine("\n\t Show IA method - declared in IA - implimented in Class C");
        }
        //public void MethodWithDefaultImplementationInIA() 
        //{
        //    Console.WriteLine("\n\t Method Imlimented In C");
        //}
    }
     public class Far
    {
        public void FarsInfo()
        {
            Console.WriteLine("\n\tFars Info Method");
        }
    }
    public class Son : Far, IA, IB //C 
    {
        public void ShowIA()
        {
            Console.WriteLine("\n\t declared in IA but implimented in class Son");
        }
        public void ShowIB()
        {
            Console.WriteLine("\n\t declared in IB but implimented in class Son");
        }
        public void SonsInfo()
        {
            Console.WriteLine("\n\tSonss Info Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IA ia = new IA();  punkt 5.
            IA ia = new C();
            ia.ShowIA();
            ia.MethodWithDefaultImplementationInIA();
            C c = new C();
            //c.ShowIA();
            //c.MethodWithDefaultImplementationInIA(); // you should choose to implement 

            Console.WriteLine("\n\t ------------IA type instance of SON -----------");
            IA ias = new Son();
            ias.ShowIA();
            ias.MethodWithDefaultImplementationInIA();

            Console.WriteLine("\n\t ------------IB type instance of SON -----------");
            IB ibs = new Son();
            ibs.ShowIA();
            ibs.ShowIB();
            ibs.MethodWithDefaultImplementationInIA();

            Console.WriteLine("\n\t -----------Far type instance of SON -----------");
            Far fs = new Son();
            fs.FarsInfo();

            Console.WriteLine("\n\t -----------Son type instance of SON -----------");
            Son s = new Son();
            s.ShowIA();
            s.ShowIB();
            s.SonsInfo();
            s.FarsInfo();
            //s.MethodWithDefaultImplementationInIA(); // you should choose to implement 
            Console.ReadKey();
        }
    }
}
