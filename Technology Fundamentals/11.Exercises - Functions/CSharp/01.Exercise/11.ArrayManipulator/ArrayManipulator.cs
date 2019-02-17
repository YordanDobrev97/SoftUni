using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static int[] Filter(int[] array, string criteria)
        {
            if (criteria == "even")
            {
                return array.Where(x => x % 2 == 0).ToArray();
            }
            return array.Where(x => x % 2 == 1).ToArray();
        }

        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] arguments = line.Split(' ');
                string command = arguments[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        if (index < 0 || index > numbers.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            int[] exhangeItems = new int[numbers.Length - 1 - index];

                            int indx = 0;
                            for (int i = numbers.Length - 1; i > index; i--)
                            {
                                exhangeItems[exhangeItems.Length - 1 - indx] = numbers[i];
                                indx++;
                            }

                            int currentIndex = index;
                            for (int i = 0; i < numbers.Length - exhangeItems.Length; i++)
                            {
                                numbers[numbers.Length - 1 - i] = numbers[currentIndex];
                                currentIndex--;
                            }

                            for (int i = 0; i < exhangeItems.Length; i++)
                            {
                                numbers[i] = exhangeItems[i];
                            }
                        }
                        break;
                    case "max":
                        if (arguments[1] == "odd")
                        {
                            int[] oddNums = Filter(numbers, "odd");
                            if (oddNums.Length == 0)
                            {
                                PrintMessageNotMatches();
                            }
                            else
                            {
                                int maxElement = oddNums.Max();
                                int indexMaxElement = Array.LastIndexOf(numbers, maxElement);
                                Console.WriteLine(indexMaxElement);
                            }

                        }
                        else
                        {
                            int[] evenNums = Filter(numbers, "even");
                            int maxElement = evenNums.Max();
                            int indexMaxElement = Array.LastIndexOf(numbers, maxElement);
                            Console.WriteLine(indexMaxElement);
                        }
                        break;
                    case "min":
                        if (arguments[1] == "even")
                        {
                            int[] evenNums = Filter(numbers, "even");
                            if (evenNums.Length == 0)
                            {
                                PrintMessageNotMatches();
                            }
                            else
                            {
                                int minElement = evenNums.Min();
                                int minElementIndex = Array.LastIndexOf(numbers, minElement);
                                Console.WriteLine(minElementIndex);
                            }
                        }
                        else
                        {
                            int[] oddNums = Filter(numbers, "odd");
                            int minElement = oddNums.Min();
                            int minElementIndex = Array.LastIndexOf(numbers, minElement);
                            Console.WriteLine(minElementIndex);
                        }
                        break;
                    case "first":
                        {
                            int count = int.Parse(arguments[1]);
                            if (InvalidCount(count, numbers))
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string criteria = arguments[2];
                                if (criteria == "even")
                                {
                                    int[] evenNumbers = Filter(numbers, "even");
                                    PrintNumbers(evenNumbers, count);
                                }
                                else
                                {
                                    int[] oddNumbers = Filter(numbers, "odd");
                                    PrintNumbers(oddNumbers, count);
                                }
                            }
                        }
                        break;
                    case "last":
                        {
                            int count = int.Parse(arguments[1]);
                            if (InvalidCount(count, numbers))
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string criteria = arguments[2];

                                if (criteria == "even")
                                {
                                    int[] evenNums = Filter(numbers, "even");
                                    if (EmptyArray(evenNums))
                                    {
                                        PrintEmptyBrackets();
                                    }
                                    else
                                    {
                                        PrintNumbers(count, evenNums);
                                    }
                                }
                                else
                                {
                                    int[] oddNums = Filter(numbers, "odd");
                                    if (EmptyArray(oddNums))
                                    {
                                        PrintEmptyBrackets();
                                    }
                                    else
                                    {
                                        PrintNumbers(count, oddNums);
                                    }
                                }
                            }
                        }
                        break;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static bool InvalidCount(int count, int[] numbers)
        {
            return count > numbers.Length;
        }

        static void PrintNumbers(int count, int[] evenNums)
        {
            if (OneElement(evenNums))
            {
                Console.WriteLine($"[{evenNums[0]}]");
            }
            else
            {
                Console.Write("[");
                for (int i = evenNums.Length - 1; i > count; i--)
                {
                    Console.Write($"{evenNums[i]} ");
                }
                Console.WriteLine("]");
            }
        }

        static void PrintNumbers(int[] nums, int count)
        {
            if (OneElement(nums))
            {
                Console.WriteLine($"[{nums[0]}]");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        Console.Write($"{nums[i]}");
                    }
                    else
                    {
                        Console.Write($"{nums[i]}, ");
                    }
                }
                Console.WriteLine("]");
            }

        }

        private static bool OneElement(int[] nums)
        {
            return nums.Length == 1;
        }

        private static bool EmptyArray(int[] evenNums)
        {
            return evenNums.Length == 0;
        }

        private static void PrintEmptyBrackets()
        {
            Console.WriteLine("[]");
        }

        private static void PrintMessageNotMatches()
        {
            Console.WriteLine("No matches");
        }
    }
}
