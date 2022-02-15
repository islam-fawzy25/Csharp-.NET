using System;

namespace JaggedArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] JaggedA = new int[4][];
            JaggedA[0] = new int[5];
            JaggedA[0][0] = 34;
            JaggedA[0][1] = 55;
            JaggedA[0][2] = 64;
            JaggedA[0][3] = 74;
            JaggedA[0][4] = 84;

            JaggedA[1] = new int[2];
            JaggedA[1][0] = 134;
            JaggedA[1][1] = 155;

            JaggedA[2] = new int[] {234, 235, 267, 287, 256, 289, 297, 233 };
            JaggedA[3] = new int[] { 334, 335, 367 };

            for (int arr = 0; arr < JaggedA.Length; arr++)
            {
                for (int val = 0; val < JaggedA[arr].Length; val++)
                {
                    Console.Write("\t"+JaggedA[arr][val]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
