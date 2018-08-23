using System;
using System.Collections.Generic;

namespace _11.Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
                totalSum += num;
            }

            totalSum -= max;
            if (totalSum == max)
            {
                Console.WriteLine($"Yes Sum = {totalSum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(totalSum - max)}");
            }
        }
    }
}
