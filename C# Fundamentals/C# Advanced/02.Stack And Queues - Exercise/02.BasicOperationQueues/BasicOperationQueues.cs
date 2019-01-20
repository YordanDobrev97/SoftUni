using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicOperationQueues
{
    public class BasicOperationQueues
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            int enqueueElementsCount = numbers[0];
            int dequeueElementsCount = numbers[1];
            int elementFound = numbers[2];

            for (int i = 0; i < enqueueElementsCount; i++)
            {
                queue.Enqueue(integers[i]);
            }

            for (int i = 0; i < dequeueElementsCount; i++)
            {
                queue.Dequeue();
            }

            bool found = false;
            foreach (var value in queue)
            {
                if (value == elementFound)
                {
                    found = true;
                    Console.WriteLine("true");
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!found)
            {
                Console.WriteLine(queue.Min());
            }
            
        }
    }
}
