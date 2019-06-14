using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GardGame
{
    class Program
    {
        static void Main()
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstCardFirstDeck = firstDeck.First();
                int firstCardSecondDeck = secondDeck.First();

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);

                if (firstCardFirstDeck > firstCardSecondDeck)
                {
                    firstDeck.Add(firstCardFirstDeck);
                    firstDeck.Add(firstCardSecondDeck);
                }
                else if (firstCardSecondDeck > firstCardFirstDeck)
                {
                    secondDeck.Add(firstCardSecondDeck);
                    secondDeck.Add(firstCardFirstDeck);   
                }
            }

            if (firstDeck.Count > 0)
            {
                int sum = firstDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}