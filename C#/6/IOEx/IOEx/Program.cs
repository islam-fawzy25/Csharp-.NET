using System;
using System.IO;

namespace IOEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo CurrDir = new DirectoryInfo(".");
            //Console.WriteLine("\n\t "+ CurrDir);
            //Console.WriteLine("\n\t " + CurrDir.FullName);
            //Console.WriteLine("\n\t " + CurrDir.Name);

            //---------------------------------------------------
            DirectoryInfo myDir1 = new DirectoryInfo("C:\\Users\\Test\\MyFolder");
            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\Test\MyFolder");
            //myDir.Create();
            //Console.WriteLine("\n\t " + myDir);
            //Console.WriteLine("\n\t " + myDir.FullName);
            //Console.WriteLine("\n\t " + myDir.Name);
            //Console.WriteLine("\n\t " + myDir.Attributes);
            //Console.WriteLine("\n\t " + myDir.CreationTime);

            //---- File -----------Write-----------Read----------------
            string[] byer = { "København", "Malmo", "Roskilde", "Odense", "Oslo"};
            string myFilePath = @"C:\Users\Test\MyFolder\MyTextFile.txt";
            File.WriteAllLines(myFilePath, byer);
            //File.AppendAllLines(myFilePath, byer);

            foreach (var by in File.ReadAllLines(myFilePath))
            {
                Console.WriteLine("\n\t"+by);
            }

            Console.ReadKey();
        }
    }
}
