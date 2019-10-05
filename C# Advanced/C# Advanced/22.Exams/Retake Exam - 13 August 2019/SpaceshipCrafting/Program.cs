using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        private static bool HasNeedMaterials(int aluminium, int carbonFiber,
        int glass, int lithium)
        {
            return aluminium != 0 && carbonFiber != 0 && glass != 0
                && lithium != 0;
        }

        static void Main()
        {
            int[] chemicalLiquidsInput = Console.ReadLine()
                .Split().
                Select(int.Parse)
                .ToArray();

            int[] physicalItemsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
               .ToArray();


            Stack<int> chemicalLiquids = new Stack<int>(physicalItemsInput);
            Queue<int> physicalItems = new Queue<int>(chemicalLiquidsInput);

            int aluminium = 0;
            int carbonFiber = 0;
            int glass = 0;
            int lithium = 0;

            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                int first = physicalItems.Peek();
                int last = chemicalLiquids.Peek();

                int sum = first + last;

                bool contains = true;
                switch (sum)
                {
                    case 25: glass++; physicalItems.Dequeue(); break;
                    case 50: aluminium++; physicalItems.Dequeue(); break;
                    case 75: lithium++; physicalItems.Dequeue(); break;
                    case 100: carbonFiber++; physicalItems.Dequeue(); break;
                    default:
                        contains = false;
                        int value = chemicalLiquids.Pop();
                        chemicalLiquids.Push(value + 3);
                        break;
                }

                if (contains)
                {
                    chemicalLiquids.Pop();
                }
            }

            if (HasNeedMaterials(aluminium, carbonFiber, glass, lithium))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            Console.WriteLine($"Liquids left: {(chemicalLiquids.Count == 0 ? "none": string.Join(", ", chemicalLiquids))}");
            Console.WriteLine($"Physical items left: {(physicalItems.Count == 0 ? "none" : string.Join(", ", physicalItems))}");

            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbonFiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");
        }
    }
}
