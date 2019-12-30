using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GrainsОfSands
{
    class Program
    {
        static void Main()
        {
            List<int> sands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            while (line != "Mort")
            {
                string[] elements = line.Split(' ');
                string command = elements[0];
                int value = int.Parse(elements[1]);
                switch (command)
                {
                    case "Add":
                        sands.Add(value);
                        break;
                    case "Remove":
                        if (sands.Contains(value))
                        {
                            sands.Remove(value);
                        }
                        else
                        {
                            if (value >= 0 && value <= sands.Count - 1)
                            {
                                sands.RemoveAt(value);
                            }
                        }
                        break;
                    case "Replace":
                        if (sands.Contains(value))
                        {
                            int replacment = int.Parse(elements[2]);

                            int indexOfValue = sands.IndexOf(value);
                            sands[indexOfValue] = replacment;
                        }
                        break;
                    case "Increase":
                        int valueIncreasing = value;
                        if (!sands.Contains(value))
                        {
                            valueIncreasing = sands.Last();
                        }
                        sands = sands.Select(x => x + valueIncreasing).ToList();
                        break;
                    case "Collapse":
                        sands = sands.Where(x => x >= value).ToList();
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", sands));
        }
    }
}
