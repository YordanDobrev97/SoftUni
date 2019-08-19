using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    public class MatchingBrackets
    {
        public static void Main()
        {
            string expression = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char value = expression[i];

                if (value == '(')
                {
                    stack.Push(i);
                }
                else if(value == ')')
                {
                    int index = stack.Pop();
                    string part = expression.Substring(index, i - index + 1);

                    Console.WriteLine(part);
                }
            }
            
        }
    }
}
