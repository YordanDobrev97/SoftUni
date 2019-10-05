using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] leftSocksInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] rightSocksInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> leftSocks = new Stack<int>(leftSocksInput);
        Queue<int> rightSocks = new Queue<int>(rightSocksInput);

        List<int> set = new List<int>();

        while (leftSocks.Count > 0 && rightSocks.Count > 0)
        {
            int leftSock = leftSocks.Pop();
            int rightSock = rightSocks.Peek();

            if (leftSock > rightSock)
            {
                int sum = leftSock + rightSock;
                rightSocks.Dequeue();
                set.Add(sum);
            }
            else if (rightSock == leftSock)
            {
                rightSocks.Dequeue();
                int top = leftSocks.Pop() + 1;
                leftSocks.Push(top);
            }
        }

        Console.WriteLine(set.Max());
        Console.WriteLine(string.Join(" ", set));
    }
}

