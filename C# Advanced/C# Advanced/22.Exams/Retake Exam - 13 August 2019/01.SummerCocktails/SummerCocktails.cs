using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SummerCocktails
{
    public class SummerCocktails
    {
        public static void Main()
        {
            int[] ingredientsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] freshnessInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsInput);
            Stack<int> freshness = new Stack<int>(freshnessInput);

            int[] freshnessLevelNeeded = { 150,250,300,400};
            string[] cocktails = { "Mimosa", "Daiquiri", "Sunshine", "Mojito" };

            SortedDictionary<string, int> coctailPairs = new SortedDictionary<string, int>();

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int currentIngredient = ingredients.Peek();
                int currentfreshnes = freshness.Peek();

                if (currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int result = currentIngredient * currentfreshnes;

                if (freshnessLevelNeeded.Contains(result))
                {
                    int indexFreesness = Array.IndexOf(freshnessLevelNeeded, result);
                    string currentCoctail = cocktails[indexFreesness];

                    if (!coctailPairs.ContainsKey(currentCoctail))
                    {
                        coctailPairs.Add(currentCoctail, 0);
                    }

                    coctailPairs[currentCoctail]++;

                    ingredients.Dequeue();
                }
                else
                {
                    ingredients.Dequeue();
                    int incrementValue = currentIngredient + 5;
                    ingredients.Enqueue(incrementValue);
                }
                freshness.Pop();
            }

            if (coctailPairs.Count == 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");

                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var kvp in coctailPairs)
            {
                Console.WriteLine($"# {kvp.Key} --> {kvp.Value}");
            }
        }
    }
}
