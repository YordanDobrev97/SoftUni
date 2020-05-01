using System;
using System.Linq;

namespace _02.Searching
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int findNumber = int.Parse(Console.ReadLine());

            numbers = numbers.OrderBy(x => x).ToArray();

            int number = BinarySearch(numbers, findNumber);
            Console.WriteLine(number);
        }

        /// <summary>
        /// Search the given array to see if the number exists. If it finds it, it returns otherwise -1
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="findNumber"></param>
        /// <returns></returns>
        private static int BinarySearch(int[] numbers, int findNumber)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }

            int middleIndex = numbers.Length / 2;
            int middleNumber = numbers[middleIndex];
           
            if (middleNumber == findNumber)
            {    
                return middleNumber;
            }

            if (middleNumber < findNumber)
            {
                //right
                int[] right = numbers.Skip(middleIndex + 1).ToArray();
                return BinarySearch(right, findNumber);
            }
            else
            {
                //left
                int[] left = numbers.Take(middleIndex).ToArray();
                return BinarySearch(left, findNumber);
            }
        }
    }
}