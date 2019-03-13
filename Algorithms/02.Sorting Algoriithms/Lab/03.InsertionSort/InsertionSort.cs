using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InsertionSort
{
    class InsertionSort
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            SortingInsertion(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void SortingInsertion(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int markCurrentNumber = numbers[i];
                int index = i;

                while (index - 1 >= 0)
                {
                    int backNumber = numbers[index - 1];

                    if (markCurrentNumber < backNumber)
                    {
                        index--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i != index)
                {
                    numbers.RemoveAt(i);
                    numbers.Insert(index, markCurrentNumber);
                }
            }
        }
    }
}
