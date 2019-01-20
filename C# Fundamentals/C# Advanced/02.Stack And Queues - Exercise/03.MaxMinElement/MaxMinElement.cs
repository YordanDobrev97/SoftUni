using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxMinElement
{
    public class MaxMinElement
    {
        public static void Main()
        {
            int countNumber = int.Parse(Console.ReadLine());

            Stack<int> maxNumbers = new Stack<int>();
            Stack<int> minNumbers = new Stack<int>();
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < countNumber; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ');

                string command = elements[0];

                switch (command)
                {
                    case "1":
                        int value = int.Parse(elements[1]);
                        numbers.Enqueue(value);

                        if (CheckCountIsZero(minNumbers))
                        {
                            AddingInCollection(minNumbers, value);
                        }

                        if (CheckCountIsZero(maxNumbers))
                        {
                            AddingInCollection(maxNumbers, value);
                        }
                        else
                        {
                            AddingNewValueInStack(maxNumbers, 
                                minNumbers, value);
                        }
                        break;
                    case "2":
                        if (numbers.Count > 0)
                        {
                            numbers.Dequeue();
                        }

                        if (maxNumbers.Count > 0)
                        {
                            maxNumbers.Pop();
                        }

                        if (minNumbers.Count > 0)
                        {
                            minNumbers.Pop();
                        }
                        break;
                    case "3":
                        if (maxNumbers.Count > 0)
                        {
                            Console.WriteLine(maxNumbers.Peek());
                        }
                       
                        break;
                    case "4":
                        if (minNumbers.Count > 0)
                        {
                            Console.WriteLine(minNumbers.Peek());
                        }
                        
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers.Reverse()));
        }

        private static void AddingNewValueInStack(Stack<int> stackMaxNumbers, Stack<int> stackMinNumbers, int value)
        {
            if (stackMaxNumbers.Count > 0)
            {
                int lastElementMax = stackMaxNumbers.Peek();
                Max(stackMaxNumbers, value, lastElementMax);
            }

            if (stackMinNumbers.Count > 0)
            {
                int lastElementMin = stackMinNumbers.Peek();
                Min(stackMinNumbers, value, lastElementMin);
            }
        }

        private static void Min(Stack<int> stack, int value, int lastElement)
        {
            if (value < lastElement)
            {
                AddingInCollection(stack, value);
            }
        }

        private static void Max(Stack<int> stack, int value, int lastElement)
        {
            if (value > lastElement)
            {
                AddingInCollection(stack, value);
            }
        }

        private static void AddingInCollection(Stack<int> stack, int value)
        {
            stack.Push(value);
        }

        private static bool CheckCountIsZero(Stack<int> minNumbers)
        {
            return minNumbers.Count == 0;
        }
    }
}
