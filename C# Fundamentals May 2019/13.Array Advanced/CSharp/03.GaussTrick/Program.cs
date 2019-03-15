using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GaussTrick
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            List<double> resultList = new List<double>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double front = numbers[i];
                double back = numbers[numbers.Count - 1 - i];

                double sum = front + back;
                resultList.Add(sum);
            }

            if (numbers.Count % 2 == 1)
            {
                double middleELement = numbers[numbers.Count / 2];
                resultList.Add(middleELement);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
