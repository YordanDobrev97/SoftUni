using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    public class ArrayManipulator
    {
        static bool containsEven = false;
        static bool containsOdd = false;
        const int DEFAULT_VALUE = -1;
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] arguments = line.Split(' ');
                string command = arguments[0];

                switch (command)
                {
                    case "exchange":
                        ExchangeNumbers(numbers, arguments);
                        break;
                    case "max":
                        if (arguments[1] == "even")
                        {
                            int maxIndexEven = ReturnIndexOfMaxEvenElement(numbers);
                            if (maxIndexEven != DEFAULT_VALUE)
                            {
                                Console.WriteLine(maxIndexEven);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        else
                        {
                            int maxIndexOdd = ReturnIndexOfMaxOddElement(numbers);
                            if (maxIndexOdd != DEFAULT_VALUE)
                            {
                                Console.WriteLine(maxIndexOdd);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "min":
                        if (arguments[1] == "even")
                        {
                            int minIndexEven = ReturnIndexOfMinEvenElement(numbers);

                            if (minIndexEven != DEFAULT_VALUE)
                            {
                                Console.WriteLine(minIndexEven);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        else
                        {
                            int minIndexOdd = ReturnIndexOfMinOddElement(numbers);

                            if (minIndexOdd != DEFAULT_VALUE)
                            {
                                Console.WriteLine(minIndexOdd);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(arguments[1]);
                        if (IsCountInOutRange(numbers, count))
                        {
                            PrintInvalidCountMessage();
                        }
                        else
                        {
                            if (arguments[2] == "even")
                            {
                                int[] firstEvenElements = ReturnFirstEvenCountElements(numbers, count);
                                if (containsEven)
                                {
                                    Console.WriteLine($"[{string.Join(", ", firstEvenElements)}]");
                                    containsEven = false;
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                            else
                            {
                                int[] firstOddElements = ReturnFirstOddCountElements(numbers, count);
                                if (containsOdd)
                                {
                                    Console.WriteLine($"[{string.Join(", ", firstOddElements)}]");
                                    containsOdd = false;
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                        }
                        break;
                    case "last":
                        count = int.Parse(arguments[1]);

                        if (IsCountInOutRange(numbers, count))
                        {
                            PrintInvalidCountMessage();
                        }
                        else
                        {
                            if (arguments[2] == "even")
                            {
                                int[] lastEvenCountElements = ReturnLastCountEvenElements(numbers, count);

                                if (containsEven)
                                {
                                    Console.WriteLine($"[{string.Join(", ", lastEvenCountElements)}]");
                                    containsOdd = false;
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                            else
                            {
                                int[] lastOddCountElements = ReturnLastCountOddElements(numbers, count);

                                if (containsOdd)
                                {
                                    Console.WriteLine($"[{string.Join(", ", lastOddCountElements)}]");
                                    containsOdd = false;
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static int[] ReturnLastCountOddElements(int[] numbers, int count)
        {
            int countOddNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    countOddNumbers++;
                }
            }

            int length = Math.Min(countOddNumbers, count);
            int[] oddNumbers = new int[length];

            int index = 0;
            int currentCounter = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1)
                {
                    containsOdd = true;
                    oddNumbers[oddNumbers.Length - 1 - index] = numbers[i];
                    currentCounter++;
                    index++;
                    if (currentCounter == count)
                    {
                        break;
                    }
                }
            }

            return oddNumbers;
        }

        private static int[] ReturnLastCountEvenElements(int[] numbers, int count)
        {
            int countEvenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countEvenNumbers++;
                }
            }

            int length = Math.Min(countEvenNumbers, count);
            int[] evenNumbers = new int[length];

            int index = 0;
            int currentCounter = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    containsEven = true;
                    evenNumbers[evenNumbers.Length - 1 - index] = numbers[i];
                    currentCounter++;
                    index++;
                    if (currentCounter == count)
                    {
                        break;
                    }
                }
            }

            return evenNumbers;
        }

        private static bool IsCountInOutRange(int[] numbers, int count)
        {
            return count < 0 || count > numbers.Length;
        }

        private static void PrintInvalidCountMessage()
        {
            Console.WriteLine("Invalid count");
        }

        private static int[] ReturnFirstOddCountElements(int[] numbers, int count)
        {
            int countOddElements = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    countOddElements++;
                }
            }

            int length = Math.Min(count, countOddElements);
            int[] oddElements = new int[length];

            int index = 0;
            int currentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    containsOdd = true;
                    currentCount++;
                    oddElements[index] = numbers[i];
                    index++;
                    if (currentCount == count)
                    {
                        break;
                    }
                }
            }

            return oddElements;
        }

        private static int[] ReturnFirstEvenCountElements(int[] numbers, int count)
        {
            // judge would not like it
            int countEvenElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countEvenElements++;
                }
            }

            int length = Math.Min(count, countEvenElements);
            int[] evenElements = new int[length];

            int index = 0;
            int currentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    containsEven = true;
                    currentCount++;
                    evenElements[index] = numbers[i];
                    index++;
                    if (currentCount == count)
                    {
                        break;
                    }
                }
            }

            return evenElements;
        }

        private static int ReturnIndexOfMinOddElement(int[] numbers)
        {
            int index = DEFAULT_VALUE;

            int currentMin = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (numbers[i] <= currentMin)
                    {
                        currentMin = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int ReturnIndexOfMinEvenElement(int[] numbers)
        {
            int index = DEFAULT_VALUE;

            int currentMin = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= currentMin)
                    {
                        currentMin = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int ReturnIndexOfMaxOddElement(int[] numbers)
        {
            int index = DEFAULT_VALUE;

            int currentMax = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (numbers[i] >= currentMax)
                    {
                        currentMax = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int ReturnIndexOfMaxEvenElement(int[] numbers)
        {
            int index = 0;
            int currentMax = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= currentMax)
                    {
                        currentMax = numbers[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        private static void ExchangeNumbers(int[] numbers, string[] arguments)
        {
            int index = int.Parse(arguments[1]);
            bool hasValidIndex = index >= 0 && index < numbers.Length;
            if (!hasValidIndex)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] elementsAfterIndex = numbers.Skip(index + 1).Take(numbers.Length - index).ToArray();
                int count = numbers.Length - elementsAfterIndex.Length;

                for (int i = 0; i < count; i++)
                {
                    int currentElement = numbers[index - i];
                    int backIndex = numbers.Length - 1 - i;

                    numbers[backIndex] = currentElement;
                }

                for (int i = 0; i < elementsAfterIndex.Length; i++)
                {
                    numbers[i] = elementsAfterIndex[i];
                }
            }
        }
    }
}
