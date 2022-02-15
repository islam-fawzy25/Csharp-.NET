using System;

namespace InheritenceDemo
{
    public class FarFar
    {
        private int farfarsDanKort; // by defualt all memmbers of class (code block) are private
        public int x;
        protected int pt; // family-protected scope
        internal int i;  // namespace scope
        protected internal int pti;  // Protected OR internal 
        protected private int prpt;

        //protected void FarFarsInfoMethod(){}
       public void FarFarsInfoMethod()
        {
            x = 6; farfarsDanKort = 111111111; i = 9;
            //Downwards=7   not visible
            Console.WriteLine("\n\t FarFars Info Method");
        }
    }
    public class Far : FarFar // FarFar - base , Far - derived
    {
        public int Downwards;
        public void FarsInfoMethod()
        {
            pt = 9; i = 5;
            //farfarsDanKort = 3; not visible
            FarFarsInfoMethod();
            Console.WriteLine("\n\t Fars Info Method");
        }
    }
    public class Person:Far //: Far //, FarFar can't have two base classes
    {
        public void PersonsInfoMethod()
        {
            //Far f = new Far();
            ////f.x = 7;
            Downwards = 8; x = 7;  pt = 3; i = 7; pti = 4; prpt = 5;
            Console.WriteLine("\n\t Persons Info Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //FarFar ff = new FarFar();
            //ff.FarFarsInfoMethod();
            //ff.x=5;
            Person p = new Person();
            p.FarFarsInfoMethod();
            p.FarsInfoMethod();
            p.PersonsInfoMethod();
            //p.pt = 6;   not visible
            p.i = 7;
            p.pti =9;
            // p.prpt = 5; not visible
        }
    }
}
