using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
    class Program
    {
        static void Main()
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
            Queue<int> chemicalLiquids = new Queue<int>(chemicalLiquidsInput);

            Stack<string[]> materials = new Stack<string[]>();
            materials.Push(new string[2] { "Aluminium", "0" });
            materials.Push(new string[2] { "Carbon fiber", "0" });
            materials.Push(new string[2] { "Glass", "0" });
            materials.Push(new string[2] { "Lithium", "0" });

            int[] validValues = {25,50,75,100};

            while (physicalItems.Count > 0 && chemicalLiquids.Count > 0)
            {
                int firstLiquid = chemicalLiquids.Dequeue();
                int lastPhysicalItem = physicalItems.Pop();

                int sum = firstLiquid + lastPhysicalItem;

                if (!validValues.Contains(sum))
                {
                    lastPhysicalItem += 3;
                    physicalItems.Push(lastPhysicalItem);
                }
                else
                {

                }
            }
        }
    }
}
