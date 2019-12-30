using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] parameters = input.Split();

                switch (parameters[0])
                {
                    case "merge":
                        int startIndex = int.Parse(parameters[1]);
                        int endIndex = int.Parse(parameters[2]);

                        if (elements.Count == 1)
                        {
                            // no merge
                            break;
                        }

                        if (startIndex > elements.Count)
                        {
                            startIndex = 0;
                        }

                        if (endIndex > elements.Count - 1)
                        {
                            endIndex = elements.Count - 1;
                        }

                        List<string> startElements =
                            GetStartToEndIndex(startIndex, endIndex, elements);

                        RemoveStartToEndIndex(startIndex, endIndex, elements);
                        string allElements = string.Join("", startElements);
                        elements.Insert(startIndex, allElements);
                        break;
                    case "divide":
                        int index = int.Parse(parameters[1]);
                        int partions = int.Parse(parameters[2]);
                        string element = elements[index];

                        elements.RemoveAt(index);

                        int getLength = element.Length / partions;
                        List<string> parts = new List<string>();
                        
                        for (int i = 0; i < partions; i++)
                        {
                            if (i == partions - 1)
                            {
                                parts.Add(element.Substring(i * getLength));
                            }
                            else
                            {
                                parts.Add(element.Substring(i * getLength, getLength));
                            }
                        }

                        elements.InsertRange(index, parts);

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        private static void RemoveStartToEndIndex(int startIndex, int endIndex, List<string> elements)
        {
            for (int i = startIndex; i <=endIndex; i++)
            {
                elements.RemoveAt(startIndex);
            }
        }

        private static List<string> GetStartToEndIndex(int startIndex, int endIndex, List<string> elements)
        {
            List<string> elementsInRange = new List<string>();

            for (int i = startIndex; i <=endIndex; i++)
            {
                elementsInRange.Add(elements[i]);
            }

            return elementsInRange;
        }
    }
}
