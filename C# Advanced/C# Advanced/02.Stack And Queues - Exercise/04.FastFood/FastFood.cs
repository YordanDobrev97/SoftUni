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

            int[] foodsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> foods = new Queue<int>(foodsInput);

            int biggestOrder = foods.Max();
            int currentQuantityFood = 0;
            bool isSuccessOrder = true;
            List<int> remainderOrders = new List<int>();
            while (foods.Count > 0)
            {
                int currentOrder = foods.Peek();

                if (currentQuantityFood + currentOrder <= quantityFood)
                {
                    currentQuantityFood += currentOrder;
                    foods.Dequeue();
                }
                else
                {
                    isSuccessOrder = false;
                    remainderOrders = foods.ToList();
                    break;
                }
            }

            Console.WriteLine(biggestOrder);

            if (isSuccessOrder)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", remainderOrders)}");
            }
        }
    }
}
