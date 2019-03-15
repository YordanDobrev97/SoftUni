using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ListManipulationBasics
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

            while (command != "end")
            {
                string[] tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        int indexRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexRemove);
                        break;
                    case "Insert":
                        int value = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index >= 0 && index < numbers.Count - 1)
                        {
                            numbers.Insert(index, value);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
