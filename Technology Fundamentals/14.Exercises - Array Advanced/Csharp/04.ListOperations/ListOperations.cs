using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    public class ListOperations
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            int num = 0;
            int index = 0;

            while (command != "End")
            {
                string[] paramsCommand = command.Split();

                switch (paramsCommand[0])
                {
                    case "Add":
                        num = int.Parse(paramsCommand[1]);
                        numbers.Add(num);
                        break;
                    case "Insert":
                        num = int.Parse(paramsCommand[1]);
                        index = int.Parse(paramsCommand[2]);
                        if (IsValidIndex(numbers, index))
                        {
                            numbers.Insert(index, num);
                        }
                        else
                        {
                            PrintInvalidIndex();
                        }
                        break;
                    case "Remove":
                        index = int.Parse(paramsCommand[1]);
                        if (IsValidIndex(numbers, index))
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            PrintInvalidIndex();
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(paramsCommand[2]);
                        if (paramsCommand[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNumber = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstNumber);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNumber = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastNumber);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void PrintInvalidIndex()
        {
            Console.WriteLine("Invalid index");
        }

        private static bool IsValidIndex(List<int> numbers, int index)
        {
            return index >= 0 && index <=numbers.Count - 1;
        }
    }
}
