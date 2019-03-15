using System;
using System.Collections.Generic;
namespace _03.GamingStore
{
    public class GamingStore
    {
        public static void Main()
        {
            Dictionary<string, double> gameStore = new Dictionary<string, double>();
            gameStore.Add("OutFall 4", 39.99);
            gameStore.Add("CS: OG", 15.99);
            gameStore.Add("Zplinter Zell", 19.99);
            gameStore.Add("Honored 2", 59.99);
            gameStore.Add("RoverWatch", 29.99);
            gameStore.Add("RoverWatch Origins Edition", 39.99);

            double budget = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            double totalPrice = 0;
            while (command != "Game Time")
            {
                string game = command;

                if (gameStore.ContainsKey(game))
                {
                    double price = gameStore[game];
                    if (price > budget)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= price;
                        totalPrice += price;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (budget != 0)
            {
                Console.WriteLine($"Total spent: ${totalPrice}. Remaining: ${budget:f2}");
            }
        }
    }
}
