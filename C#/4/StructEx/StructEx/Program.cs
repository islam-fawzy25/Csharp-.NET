using System;

namespace StructEx
{
    struct Kursist
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kursist[] elever = new Kursist[2];
            for (int i = 0; i < elever.Length; i++)     // 0 , 1
            {
                Console.WriteLine("\n\t Id = ?");
                int eId;
                int.TryParse(Console.ReadLine(), out eId);
                elever[i].Id = eId;

                Console.WriteLine("\n\t Name = ?");
                elever[i].Name = Console.ReadLine();
            }
            Console.WriteLine("\n\t ------------Kursist data------------------\n");

            foreach (var elev in elever)
            {
                //Console.WriteLine("\n\t" + elev);
                Console.WriteLine($"\n\t Id =  {elev.Id}\t Name = {elev.Name} ");
            }

        }
    }
}
