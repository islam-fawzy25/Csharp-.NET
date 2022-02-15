using System;

namespace ConstructorChainingDemo
{
    public class LivingThing
    {
        public LivingThing()
        {
            Console.WriteLine("\n\t Cunstroctor in LivingThing Class");
        }
        public LivingThing(string hilsen)
        {
            Console.WriteLine("\n\t Cunstroctor in LivingThing Class says \t" + hilsen);
        }
    }
    public class Animal : LivingThing
    {
        public Animal() : base("Hej")
        {
            Console.WriteLine("\n\t Cunstroctor in Animal Class");
        }
        public Animal(string lyd) : this()
        {
            Console.WriteLine("\n\t lyd = " + lyd);
        }
    }
     public class Cat : Animal
    {
        public Cat() : base("Miyoun Miyoun")
        {
            Console.WriteLine("\n\t Cunstroctor in CAT Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat myKat = new Cat();

            Console.ReadKey();
        }
    }
}
