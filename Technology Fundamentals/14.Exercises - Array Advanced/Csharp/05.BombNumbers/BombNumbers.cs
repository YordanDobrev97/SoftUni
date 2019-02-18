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

            if (numbers.Contains(number))
            {
                int indexNumber = numbers.IndexOf(number);
                //TODO...
            }
        }
    }
}
