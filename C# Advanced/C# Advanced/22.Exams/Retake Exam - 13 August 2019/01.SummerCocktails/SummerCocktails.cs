using System;
using System.Collections.Generic;
using System.Linq;

public class SummerCocktails
{
    public static void Main()
    {
        int[] ingredientsValues = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] freshnessValues = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> ingredients = new Queue<int>(ingredientsValues);
        Stack<int> freshness = new Stack<int>(freshnessValues);
        Dictionary<string, int> mixCocktails = new Dictionary<string, int>();

        while (ingredients.Count > 0 && freshness.Count > 0)
        {
            int currentIngeredient = ingredients.Peek();

            if (currentIngeredient == 0)
            {
                ingredients.Dequeue();
                continue;
            }

            int currentFreshness = freshness.Peek();
            int product = currentIngeredient * currentFreshness;

            switch (product)
            {
                case 150:
                    RemoveIngredient(ingredients);
                    RemoveFreshness(freshness);
                    if (!mixCocktails.ContainsKey("Mimosa"))
                    {
                        mixCocktails.Add("Mimosa", 0);
                    }
                    mixCocktails["Mimosa"]++;
                    break;
                case 250:
                    RemoveIngredient(ingredients);
                    RemoveFreshness(freshness);
                    if (!mixCocktails.ContainsKey("Daiquiri"))
                    {
                        mixCocktails.Add("Daiquiri", 0);
                    }
                    mixCocktails["Daiquiri"]++;
                    break;
                case 300:
                    RemoveIngredient(ingredients);
                    RemoveFreshness(freshness);
                    if (!mixCocktails.ContainsKey("Sunshine"))
                    {
                        mixCocktails.Add("Sunshine", 0);
                    }
                    mixCocktails["Sunshine"]++;
                    break;
                case 400:
                    RemoveIngredient(ingredients);
                    RemoveFreshness(freshness);
                    if (!mixCocktails.ContainsKey("Mojito"))
                    {
                        mixCocktails.Add("Mojito", 0);
                    }
                    mixCocktails["Mojito"]++;
                    break;
                default:
                    freshness.Pop();
                    ingredients.Enqueue(currentIngeredient + 5);
                    ingredients.Dequeue();
                    break;
            }
        }

        if (mixCocktails.Count == 4)
        {
            Console.WriteLine("It's party time! The cocktails are ready!");
        }
        else
        {
            Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
        }

        foreach (var item in mixCocktails.OrderBy(x => x.Key))
        {
            Console.WriteLine($"# {item.Key} --> {item.Value}");
        }
    }

    private static void RemoveFreshness(Stack<int> freshness)
    {
        if (freshness.Count > 0)
        {
            freshness.Pop();
        }
    }

    private static void RemoveIngredient(Queue<int> ingredients)
    {
        if (ingredients.Count > 0)
        {
            ingredients.Dequeue();
        }
    }
}