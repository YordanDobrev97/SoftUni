using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.HappyCat_Parking
{
    class Program
    {
        static void Main()
        {
            int numberDays = int.Parse(Console.ReadLine());
            int numberHours = int.Parse(Console.ReadLine());

            double totalSum = 0;
            var pairs = new Dictionary<int, double>();
            for (int i = 1; i <=numberDays; i++)
            {
                for (int j = 1; j <=numberHours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        totalSum += 2.50;
                    }
                    else if(i % 2 == 1 && j % 2 == 0)
                    {
                        totalSum += 1.25;
                    }
                    else
                    {
                        totalSum += 1;
                    }
                }

                pairs[i] = totalSum;
                totalSum = 0;
            }

            foreach (var kvp in pairs)
            {
                Console.WriteLine($"Day: {kvp.Key} - {kvp.Value:f2} leva");
            }
            
            var sum = pairs.Values.Sum();
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
