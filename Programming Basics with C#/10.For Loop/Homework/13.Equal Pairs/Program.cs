using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int value = 0;
            bool hasEqualPairs = true;
            var values = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (value == 0)
                {
                    value = num1 + num2;
                    values.Add(value);
                }
                else
                {
                    int sum = num1 + num2;
                    if (value != sum)
                    {
                        hasEqualPairs = false;
                        values.Add(sum);
                    }
                }
            }

            if (hasEqualPairs)
            {
                Console.WriteLine($"Yes, value={value}");
            }
            else
            {
                int min = values.Min();
                int max = values.Max();
                int diff = Math.Abs(max - min);
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
