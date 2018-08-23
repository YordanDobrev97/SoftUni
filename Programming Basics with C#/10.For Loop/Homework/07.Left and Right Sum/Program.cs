using System;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            int rigthSum = 0;

            for (int i = 0; i < n; i++)
            {
                rigthSum += int.Parse(Console.ReadLine());
            }

            if (leftSum == rigthSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rigthSum)}");
            }
        }
    }
}
