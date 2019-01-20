using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicOperationStack
{
    public class BasicOperationStack
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int elementPushCount = numbers[0];
            int elementPopCount = numbers[1];
            int elementFound = numbers[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementPushCount; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < elementPopCount; i++)
            {
                stack.Pop();
            }

            bool found = false;
            foreach (var value in stack)
            {
                if(value == elementFound)
                {
                    found = true;
                    Console.WriteLine("true");
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!found)
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
