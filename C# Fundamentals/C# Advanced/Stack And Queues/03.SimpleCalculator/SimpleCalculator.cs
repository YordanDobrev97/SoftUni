using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            Stack<string> stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item);
            }
            Stack<string> reversedStack = new Stack<string>();

            foreach (var item in stack)
            {
                reversedStack.Push(item);
            }
             

            int sum = int.Parse(reversedStack.Pop());

            while (reversedStack.Count > 0)
            {
                string value = reversedStack.Pop();

                if (value == "+")
                {
                    int getNumberValue = int.Parse(reversedStack.Pop());
                    sum += getNumberValue;
                }
                else if (value == "-")
                {
                    int getNumberValue = int.Parse(reversedStack.Pop());
                    sum -= getNumberValue;
                }
                
            }

            Console.WriteLine(Math.Abs(sum));
        }
    }
}
