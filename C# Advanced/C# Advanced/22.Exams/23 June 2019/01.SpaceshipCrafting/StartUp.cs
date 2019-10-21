using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var chemicalLiquidsInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        
        var physicalItemsInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        Queue<int> chemicalLiquids = new Queue<int>(chemicalLiquidsInput);
        Stack<int> physicalItems = new Stack<int>(physicalItemsInput);

        int countGlass = 0;
        int countAluminium = 0;
        int countLithium = 0;
        int countCarbonFiber = 0;

        while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
        {
            int chemicalItem = chemicalLiquids.Peek();
            int physicalItem = physicalItems.Peek();
            int sum = chemicalItem + physicalItem;

            switch (sum)
            {
                case 25:
                    countGlass++;
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                    break;
                case 50:
                    countAluminium++;
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                    break;
                case 75:
                    countLithium++;
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                    break;
                case 100:
                    countCarbonFiber++;
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                    break;
                default:
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                    physicalItems.Push(physicalItem + 3);
                    break;

            }
        }

        if (countGlass != 0 && countAluminium != 0 && countLithium != 0 && countCarbonFiber != 0)
        {
            Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
        }
        else
        {
            Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
        }

        if (chemicalLiquids.Count != 0)
        {
            Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
        }
        else
        {
            Console.WriteLine($"Liquids left: none");
        }

        if (physicalItems.Count != 0)
        {
            Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
        }
        else
        {
            Console.WriteLine($"Physical items left: none");
        }
        

        Console.WriteLine($"Aluminium: {countAluminium}");
        Console.WriteLine($"Carbon fiber: {countCarbonFiber}");
        Console.WriteLine($"Glass: {countGlass}");
        Console.WriteLine($"Lithium: {countLithium}");

    }
}

