using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    public class FastFood
    {
        public static void Main()
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < order.Length; i++)
            {
                int foodQuantity = order[i];
                queue.Enqueue(foodQuantity);
                quantityFood -= foodQuantity;
            }

            int max = queue.Max();

            Console.WriteLine(max);

            if (quantityFood > 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: 76");
            }
        }
    }
}
