using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(bool.TryParse("false", out bool result));

            string pattern = "\\s+";
            List<string> collection = Regex.Split(Console.ReadLine(), pattern)
                .ToList();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] commandParts = line.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "reverse":
                        int start = int.Parse(commandParts[2]);
                        int count = int.Parse(commandParts[4]);

                        if (IsValidParameters(start, count, collection))
                        {

                            string[] reversePart = collection.Skip(start)
                                .Take(count)
                                .ToArray()
                                .Reverse()
                                .ToArray();

                            collection.RemoveRange(start, count);

                            collection.InsertRange(start, reversePart);

                        }
                        else
                        {
                            MessageInvalidParameters();
                        }
                        break;
                    case "sort":
                        start = int.Parse(commandParts[2]);
                        count = int.Parse(commandParts[4]);

                        if (IsValidParameters(start, count, collection))
                        {
                            string[] reversePart = collection.Skip(start)
                            .Take(count)
                            .ToArray()
                            .OrderBy(x => x)
                            .ToArray();

                            collection.RemoveRange(start, count);

                            collection.InsertRange(start, reversePart);
                        }
                        else
                        {
                            MessageInvalidParameters();
                        }
                        break;
                    case "rollLeft":
                        count = int.Parse(commandParts[1]);

                        if (count <= collection.Count)
                        {
                            IEnumerable<string> partCollection = collection.Take(count);
                            collection.InsertRange(collection.Count, partCollection);

                            collection.RemoveRange(0, count);
                        }
                        else
                        {
                            MessageInvalidParameters();
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(commandParts[1]);

                        if (count <= collection.Count)
                        {
                            string[] parts = collection.Skip(collection.Count - count)
                                .Take(count).ToArray();

                            collection.InsertRange(0, parts);
                            collection.RemoveRange(collection.Count - count, count);
                        }
                        else
                        {
                            MessageInvalidParameters();
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static void MessageInvalidParameters()
        {
            Console.WriteLine("Invalid input parameters.");
        }

        private static bool IsValidParameters(int start, int count, List<string> collection)
        {
            return start >= 0 && start + count < collection.Count - 1 && count <= collection.Count;
        }
    }
}
