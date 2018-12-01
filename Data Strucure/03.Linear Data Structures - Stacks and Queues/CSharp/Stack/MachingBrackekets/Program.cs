using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string expression
            = "((10 * (2 * 20) + (20 - (10 * 5) - 3) / 4) + 50) / 40";
        Stack<int> brackets = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets.Push(i);
            }
            else if(expression[i] == ')')
            {
                int index = brackets.Pop();
                string substring = expression.Substring(index, i + 1 - index);
                Console.WriteLine(substring);
            }
        }
    }
}

