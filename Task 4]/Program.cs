using System;

namespace Task_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Enter the index of product");
            int index = Int32.Parse(Console.ReadLine());

            store.ShowInfoByIndex(index);
            Console.WriteLine("Enter the title of product");
            string title = Console.ReadLine();
            store.ShowInfoByTitle(title);

        }
    }
}
