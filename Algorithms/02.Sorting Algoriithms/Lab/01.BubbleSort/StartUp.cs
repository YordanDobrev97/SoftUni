using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BubbleSort
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = { 10, 7, 0, 15, 2, 4, 9, 24 };
            //List<int> sortedNumbers = new List<int>();
            //sortedNumbers = BubbleSort(numbers, sortedNumbers);
            BubbleSort(numbers);
            Console.WriteLine(string.Join(" ", numbers));


        }
        public static List<int> BubbleSort(int[] numbers, List<int> sortedNumbers)
        {
            List<int> copyNumbers = numbers.ToList();

            while (copyNumbers.Count > 0)
            {
                int max = copyNumbers.Max();
                sortedNumbers.Add(max);
                copyNumbers.Remove(max);
            }

            sortedNumbers.Reverse();
            return sortedNumbers;
        }

        public static void BubbleSort(int[] numbers)
        {
            bool isSwapped = true;

            do
            {
                isSwapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentNumber = numbers[i];
                    int nextNumber = numbers[i + 1];

                    if (currentNumber > nextNumber)
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        isSwapped = true;
                    }
                }

            } while (isSwapped);
        }
    }
}
