using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Error! String value");
                Environment.Exit(0);
            }
            Console.WriteLine("Enter the number of column");
            if (!int.TryParse(Console.ReadLine(), out int j))
            {
                Console.WriteLine("Error! String value");
                Environment.Exit(0);
            }

            MyMatrix array = new MyMatrix(k, j);
            Random random_number = new Random();

            for (int i = 0; i < k; i++)
            {
                
                for (int b = 0; b  < j;  b++)
                {
                    array[i, b] = random_number.Next(0, 100);
                }
            }

            for (int i = 0; i < k; i++)
            {
                for (int d = 0; d < j; d++)
                {
                    Console.Write(array[i, d] + " ");
                }
                Console.WriteLine();
            }
            







        }
    }
}
