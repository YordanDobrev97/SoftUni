using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> frontParentheses = new Stack<char>();
            Stack<char> backParentheses = new Stack<char>();

            for (int i = 0; i < input.Length / 2; i++)
            {
                char value = input[i];
                frontParentheses.Push(value);
            }

            for (int i = input.Length - 1; i >= input.Length / 2; i--)
            {
                char value = input[i];
                backParentheses.Push(value);
            }

            bool isEqual = false;
            int sizeFront = frontParentheses.Count;
            int sizeBack = backParentheses.Count;

            while (frontParentheses.Count > 0 && backParentheses.Count > 0)
            {
                char front = frontParentheses.Pop();
                char back = backParentheses.Pop();

                if (front == '(' && back == ')')
                {
                    isEqual = true;
                }
                else if(front == '[' && back == ']')
                {
                    isEqual = true;
                }
                else if(front == '{' && back == '}')
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual && (sizeFront == sizeBack))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
