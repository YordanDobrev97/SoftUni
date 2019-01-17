using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    public class ReverseStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> strings = new Stack<char>();

            foreach (var item in input)
            {
                strings.Push(item);
            }

            Console.WriteLine(string.Join("", strings));
        }
    }
}
