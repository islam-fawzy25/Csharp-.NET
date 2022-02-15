using System;

namespace DoWhileSwitchEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int dagNr;
            do
            {
                Console.WriteLine("\n\t please enter nr. 1-7, get day name back. enter 0 to stop program");
                //dagNr = int.Parse(Console.ReadLine());
                 //int.TryParse(Console.ReadLine(), out dagNr); // default value 0
                dagNr = int.TryParse(Console.ReadLine(), out dagNr)? dagNr : 100; // default value 100
                switch (dagNr)
                {
                    case 1:
                        Console.WriteLine("\n\t Mandag");
                        break;
                    case 2:
                        Console.WriteLine("\n\t Tirsdag");
                        break;
                    case 3:
                        Console.WriteLine("\n\t Onsdag");
                        break;
                    case 4:
                        Console.WriteLine("\n\t Torsdag");
                        break;
                    case 5:
                        Console.WriteLine("\n\t Fredag");
                        break;
                    case 6:
                        Console.WriteLine("\n\t Lørdag");
                        break;
                    case 7:
                        Console.WriteLine("\n\t Søndag");
                        break;
                
                    default:
                        if (dagNr != 0 )
                        {
                            Console.WriteLine("\n\t jeg ved det ikke");
                        }
                        //Console.WriteLine("\n\t jeg ved det ikke");
                        break;
                }
            } while (dagNr != 0 );
        }
    }
}
