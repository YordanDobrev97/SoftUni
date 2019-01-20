using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    public class StackSum
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            foreach (var item in inputNumbers)
            {
                numbers.Push(item);
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] values = command.Split(' ');

                if (values[0].ToLower() == "add")
                {
                    int firstNumber = int.Parse(values[1]);
                    int secondNumber = int.Parse(values[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                else if(values[0].ToLower() == "remove")
                {
                    int countRemove = int.Parse(values[1]);

                    if (countRemove < numbers.Count())
                    {
                        for (int i = 0; i < countRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
