using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] expression = Console.ReadLine().Split(" ");
            Stack<string> stack = new Stack<string>();

            int sum = 0;
            foreach (var item in expression)
            {
                stack.Push(item);
            }

            stack.Reverse();
            while (stack.Count > 0)
            {

            }

            Console.WriteLine(sum);
        }
    }
}
