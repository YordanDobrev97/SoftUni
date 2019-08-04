using System;

namespace _01.Problem1
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] elements = line.Split();

                string command = elements[0].ToLower();

                if (command == "translate")
                {
                    var old = elements[1][0];
                    var replacment = elements[2][0];

                    text = text.Replace(old, replacment);
                    Console.WriteLine(text);
                }
                else if (command == "includes")
                {
                    string str = elements[1];

                    if (text.Contains(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "start")
                {
                    string elementStart = elements[1];

                    if (text.StartsWith(elementStart))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "findindex")
                {
                    int lastIndex = text.LastIndexOf(elements[1]);
                    if (lastIndex != -1)
                    {
                        Console.WriteLine(lastIndex);
                    }
                }
                else if (command == "remove")
                {
                    int startIndex = int.Parse(elements[1]);
                    int count = int.Parse(elements[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                line = Console.ReadLine();
            }
        }
    }
}
