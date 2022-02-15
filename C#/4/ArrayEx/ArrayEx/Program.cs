using System;

namespace ArrayEx
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            //int[] A1 = new int[] {4,6,7,8,9 };  length 5  last index = length-1

            //A[0] = 34;
            //A[1] = 57;
            //A[2] = A[0] + A[1] - 50;
            //A[3] = A[2] - A[0] + 67;
            //Console.WriteLine("\n\t Last value please");
            //int.TryParse(Console.ReadLine(), out A[4]);

            //Console.WriteLine("\n------------Values in Array-------------\n");
            ////ForeachMethod(A);
            //Array.Sort(A);
            //Console.WriteLine("\n------------Sorted Values-------------\n");
            //ForeachMethod(A);

            //Console.WriteLine("\n------------Sorted Values desc-------------\n");
            //Array.Reverse(A);
            //ForeachMethod(A);

            Customer[] kunder = new Customer[3];
            kunder[0] = new Customer(111, "Ole");
            kunder[1] = new Customer(222, "Ahmed");
            kunder[2] = new Customer(333, "Mark");

            //foreach (var k in kunder)
            //{
            //    Console.WriteLine($"\n\t Id = {k.Id}\t Name = {k.Name}");
            //}

            //---------------------2 -D -- Array---------------------

            int[,] matrix = new int[3, 4]
            {
                { 04, 05, 06, 07 },
                { 15, 18, 17, 19 },
                { 23, 26, 28, 29 }
            };

            //foreach (var item in matrix)
            //{
            //    //Console.WriteLine("\n\t " + item);
            //    Console.Write("\t " + item);
            //}

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write("\t " + matrix[row, col]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }

        private static void ForeachMethod(int[] A)
        {
            foreach (var item in A)
            {
                Console.WriteLine("\n\t " + item);
            }
        }
    }
}
