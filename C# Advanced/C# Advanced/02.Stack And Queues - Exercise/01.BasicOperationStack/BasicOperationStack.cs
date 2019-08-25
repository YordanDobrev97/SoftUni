using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicOperationStack
{
    public class BasicOperationStack
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int popSize = int.Parse(input[1]);
            int foundNum = int.Parse(input[2]);

            string[] numbersInput = Console.ReadLine().Split();
            Stack<int> numbers = new Stack<int>();

            foreach (var number in numbersInput)
            {
                numbers.Push(int.Parse(number));
            }

            for (int i = 0; i < popSize; i++)
            {
                if (!numbers.TryPop(out int result))
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
