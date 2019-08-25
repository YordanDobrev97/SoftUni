using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicOperationQueues
{
    public class BasicOperationQueues
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int dequeSize = int.Parse(input[1]);
            int foundNum = int.Parse(input[2]);

            string[] numbersInput = Console.ReadLine().Split();
            Queue<int> numbers = new Queue<int>();

            foreach (var number in numbersInput)
            {
                numbers.Enqueue(int.Parse(number));
            }

            for (int i = 0; i < dequeSize; i++)
            {
                if (!numbers.TryDequeue(out int result))
                {
                    break;
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Contains(foundNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
