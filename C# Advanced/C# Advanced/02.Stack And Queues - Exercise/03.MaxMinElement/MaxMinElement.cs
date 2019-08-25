using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxMinElement
{
    public class MaxMinElement
    {
        public static void Main()
        {
            int coutLines = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < coutLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "1":
                        numbers.Push(int.Parse(input[1]));
                        break;
                    case "2":
                        numbers.TryPop(out int result);
                        break;
                    case "3":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
