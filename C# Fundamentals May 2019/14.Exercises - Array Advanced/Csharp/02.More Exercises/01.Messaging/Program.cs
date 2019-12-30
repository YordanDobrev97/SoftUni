using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static int GetSumNumber(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine();

            List<char> result = new List<char>();

            int count = 0;
            foreach (var number in numbers)
            {
                int sumOfNumber = GetSumNumber(number);

                if (sumOfNumber > line.Length)
                {
                    sumOfNumber = sumOfNumber % line.Length;                    
                }

                char element = line[sumOfNumber + count];
                result.Add(element);
                count++;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
