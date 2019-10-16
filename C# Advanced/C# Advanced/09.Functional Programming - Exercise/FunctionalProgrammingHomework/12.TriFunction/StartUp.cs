using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    public class StartUp
    {
        public static void Main()
        {
            int value = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int> sumAscii = line =>
            {
                int sum = 0;

                foreach (var item in line)
                {
                    sum += item;
                }

                return sum;
            };

            Action<Func<string, int>, List<string>> maxNameAsciiSum = (function, listNames) =>
            {
                int maxSum = 0;
                string nameMax = string.Empty;

                foreach (var name in listNames)
                {
                    int sumAsciiName = function(name);
                    if (sumAsciiName > maxSum)
                    {
                        maxSum = sumAsciiName;
                        nameMax = name;
                    }
                }

                Console.WriteLine(nameMax);
            };

            maxNameAsciiSum(sumAscii, names);
        }
    }
}
