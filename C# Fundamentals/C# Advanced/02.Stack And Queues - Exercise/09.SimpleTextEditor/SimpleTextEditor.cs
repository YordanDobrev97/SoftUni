using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            int numberOperations = int.Parse(Console.ReadLine());

            Stack<string> operations = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < numberOperations; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ');

                string value = string.Empty;
                if (elements.Length == 2)
                {
                    value = elements[1];
                }

                string command = elements[0];

                switch (command)
                {
                    case "1":
                        operations.Push(text.ToString());
                        text.Append(value);
                        break;
                    case "2":
                        operations.Push(text.ToString());
                        int countRemove = int.Parse(value);
                        text.Remove(text.Length - countRemove, countRemove);
                        break;
                    case "3":
                        int index = int.Parse(value);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(operations.Pop());
                        break;
                }
            }
        }
    }
}
