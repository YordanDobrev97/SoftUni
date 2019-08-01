using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.VaporWinterSale
{
    class Program
    {
        static void Main()
        {
            string[] games = Console.ReadLine().Split(", ");

            Dictionary<string, double> gamePrice = new Dictionary<string, double>();
            Dictionary<string, string> gameDLC = new Dictionary<string, string>();

            foreach (var game in games)
            {
                string nameGame = game.Split("-")[0];
                if (game.Contains("-"))
                {
                    double price = double.Parse(game.Split("-")[1]);

                    if (!gamePrice.ContainsKey(nameGame))
                    {
                        gamePrice.Add(nameGame, price);
                    }
                }
                else
                {
                    nameGame = nameGame.Split(":")[0];
                    if (gamePrice.ContainsKey(nameGame))
                    {
                        gameDLC.Add(nameGame, game.Split(":")[1]);
                    }
                }
            }

            foreach (var item in gameDLC.OrderBy(x => x.Value))
            {
                double price = gamePrice[item.Key] + (gamePrice[item.Key] * 0.20);

                price -= price * 0.50;

                Console.WriteLine($"{item.Key} - {item.Value} - {price:f2}");
            }

            foreach (var item in gameDLC)
            {
                gamePrice.Remove(item.Key);
            }

            foreach (var item in gamePrice
                .OrderByDescending(x => x.Value))
            {
                double price = item.Value - (item.Value * 0.20);
                Console.WriteLine($"{item.Key} - {price:f2}");
            }
        }
    }
}
