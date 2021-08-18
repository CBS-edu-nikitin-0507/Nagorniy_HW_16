using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_
{
    class Store
    {
        Article[] articles = { new Article("Fanta", "Prospekt", 12.32), new Article("Sprite", "Fora", 15), new Article("Sprite", "Silpo", 14.55) };

        public void ShowInfoByIndex(int index)
        {
            bool check = false;
            for (int i = 0; i < articles.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine($"Title: {articles[index].Title}\nMagazine: {articles[index].Magazine}\nPrize: {articles[index].Prize}");
                    check = true;
                    break;
                }
            }
            if (check = false)
            {
                Console.WriteLine("Product with this index does not exist");
            }
           

        }
        public void ShowInfoByTitle(string title)
        {
            bool check = false;
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Title == title)
                {
                    Console.WriteLine($"Magazine: {articles[i].Magazine}\nPrize: {articles[i].Prize}\n");
                    check = true;
                    
                }
            }
            if (check = false)
            {
                Console.WriteLine("Product with this title doen not exist");
            }
        }
    }
}
