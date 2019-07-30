using System;
using System.Collections.Generic;

namespace _01.Problem1
{
    class Program
    {
        static void Main()
        {
            string result = string.Empty;

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] elements = line.Split();
                string command = elements[0];

                if (command == "Add")
                {
                    result += elements[1];
                }
                else if (command == "Upgrade")
                {
                    var nextSymbol = (char)(elements[1][0] + 1);

                    result = result.Replace(elements[1][0], nextSymbol);
                }
                else if (command == "Index")
                {
                    List<int> indexes = new List<int>();
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == elements[1][0])
                        {
                            indexes.Add(i);
                        }
                    }

                    if (indexes.Count == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", indexes));
                    }
                }
                else if (command == "Remove")
                {
                    result = result.Replace(elements[1], "");
                }
                else if (command == "Print")
                {
                    Console.WriteLine(result);
                }

                line = Console.ReadLine();
            }
        }
    }
}
