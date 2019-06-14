using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>() { 1, 5, 3, 2, 0, 2, 23 };

            int size = nums.Count;
            for (int i = 0; i < size; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums.RemoveAt(i);
                }
            }


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
