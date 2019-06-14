using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = bombNumbers[0];
            int power = bombNumbers[1];

            int start = 0;
            int index = numbers.IndexOf(number, start);
            
            while (index != -1)
            {
                DetonateLeft(numbers, index, power);

                index = numbers.IndexOf(number);

                DetonateRight(numbers, index, power);

                numbers.Remove(number);

                if (!numbers.Contains(number))
                {
                    break;
                }

                index = numbers.IndexOf(number, index + 1);
            }

            int sum = sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void DetonateRight(List<int> numbers, int index, int power)
        {
            int counter = 0;
            int indexRight = index + 1;

            while (counter < power)
            {
                if (indexRight >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(indexRight);
                counter++;
            }
        }

        private static void DetonateLeft(List<int> numbers, int index, int power)
        {
            int counter = 0;

            int indexLeft = index - 1;
            while (counter < power)
            {
                if (indexLeft < 0)
                {
                    break;
                }

                numbers.RemoveAt(indexLeft);

                indexLeft--;
                counter++;
            }
        }
    }
}
