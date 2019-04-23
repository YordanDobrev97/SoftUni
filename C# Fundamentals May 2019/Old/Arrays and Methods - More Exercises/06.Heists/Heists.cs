using System;
using System.Linq;
using System.Collections.Generic;
namespace _06.Heists
{
    public class Heists
    {
        public static void Main()
        {
            int[] prices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();

            int jewelsPrice = prices[0];
            int goldPrice = prices[1];

            int totalJewels = 0;
            int totalGold = 0;

            int totalExpenses = 0;
            int totalEarnings = 0;

            while (line != "Jail Time")
            {
                string[] items = line.Split();
                string loot = items[0];
                int price = int.Parse(items[1]);

                int countJewels = 0;
                int countGold = 0;

                totalExpenses += price;
                
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        countJewels++;
                    }
                    else if(loot[i] == '$')
                    {
                        countGold++;
                    }
                }

                totalJewels = countJewels * jewelsPrice;
                totalGold = countGold * goldPrice;

                totalEarnings += totalJewels + totalGold;

                line = Console.ReadLine();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}
