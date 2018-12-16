using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationAdvanced
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            bool hasChange = false;
            while (command != "end")
            {
                string[] tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        hasChange = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        int indexRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexRemove);
                        hasChange = true;
                        break;
                    case "Insert":
                        int value = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        hasChange = true;
                        if (index >= 0 
                            && index < numbers.Count - 1)
                        {
                            numbers.Insert(index, value);
                        }
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)
                            .ToList()));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)
                            .ToList()));
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        value = int.Parse(tokens[2]);
                        List<int> filter = numbers;
                        switch (condition)
                        {
                            case ">=":
                                filter = filter.Where(x => x >= value)
                                    .ToList();
                                break;
                            case ">":
                                filter = filter.Where(x => x > value)
                                    .ToList();
                                break;
                            case "<=":
                                filter = filter.Where(x => x <= value)
                                    .ToList();
                                break;
                            case "<":
                                filter = filter.Where(x => x < value)
                                    .ToList();
                                break;
                        }

                        Console.WriteLine(string.Join(" ", filter));
                        break;
                }

                command = Console.ReadLine();
            }

            if (hasChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
