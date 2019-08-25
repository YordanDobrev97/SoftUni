using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            string text = string.Empty;

            int countLines = int.Parse(Console.ReadLine());

            Stack<string> statesOfString = new Stack<string>();
            statesOfString.Push(text);

            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string command = input[0];
                if (command == "1")
                {
                    text += input[1];
                    statesOfString.Push(text);
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    text = text.Substring(0, text.Length - count);
                    statesOfString.Push(text);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    statesOfString.Pop();
                    text = statesOfString.Peek();
                }
            }
        }
    }
}
