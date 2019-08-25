using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    public class FashionBoutique
    {
        public static void Main()
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int currentCapacity = 0;
            int countRacks = 1;

            while (box.Count > 0)
            {
                int currentGarment = box.Peek();
                currentCapacity += currentGarment;

                if (currentCapacity > capacity)
                {
                    countRacks++;
                    currentCapacity = 0;
                }
                else
                {
                    box.Pop();
                }
            }

            Console.WriteLine(countRacks);
        }
    }
}
