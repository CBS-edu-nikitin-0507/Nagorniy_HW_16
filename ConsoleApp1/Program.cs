using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 5, 2, -1, 15, 67, -54, -34 };

            Array array = arr as Array;

            int max_value = 0;
            int min_value = 0;
            int sum = 0;
            int avarage;
            for (int i = 0; i < array.Length; i++)
            {
                sum += arr[i];
                if (i == 0)
                {
                    max_value = arr[i];
                    min_value = arr[i];
                }
                if (max_value < arr[i])
                {
                    max_value = arr[i];
                }
                else
                {
                    if (min_value > arr[i])
                    {
                        min_value = arr[i];
                    }
                }
                if (arr[i] < 0)
                {
                    Console.WriteLine($"The value {arr[i]} with index {i} is negative");
                }

            }
            avarage = sum / array.Length;
            Console.WriteLine($"Max value = {max_value}\nMin value = {min_value}\nSum = {sum}\nAvarage = {avarage}");


        }


    }
}
