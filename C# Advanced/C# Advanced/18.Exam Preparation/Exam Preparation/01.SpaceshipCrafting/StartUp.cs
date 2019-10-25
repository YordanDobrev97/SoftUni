using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] chemicalLiquidsInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] physicalItemsInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> physicalItems = new Stack<int>(physicalItemsInput);
        Queue<int> firstLiquid = new Queue<int>(chemicalLiquidsInput);

        Dictionary<string, int> material = new Dictionary<string, int>();
        material.Add("Aluminium", 0);
        material.Add("Carbon fiber", 0);
        material.Add("Glass", 0);
        material.Add("Lithium", 0);

        while (physicalItems.Count > 0 && firstLiquid.Count > 0)
        {
            int currentLiquid = firstLiquid.Dequeue();
            int physicalItem = physicalItems.Pop();

            int sum = currentLiquid + physicalItem;

            if (sum == 25)
            {
                material["Glass"]++;
            }
            else if (sum == 50)
            {
                material["Aluminium"]++;
            }
            else if (sum == 75)
            {
                material["Lithium"]++;
            }
            else if (sum == 100)
            {
                material["Carbon fiber"]++;
            }
            else
            {
                physicalItems.Push(physicalItem + 3);
            }
        }

        if (!material.ContainsValue(0))
        {
            Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
        }
        else
        {
            Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
        }

        if (firstLiquid.Count == 0)
        {
            Console.WriteLine("Liquids left: none");
        }
        else
        {
            Console.WriteLine($"Liquids left: {string.Join(", ", firstLiquid)}");
        }

        if (physicalItems.Count == 0)
        {
            Console.WriteLine("Physical items left: none");
        }
        else
        {
            Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
        }

        foreach (var item in material)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}