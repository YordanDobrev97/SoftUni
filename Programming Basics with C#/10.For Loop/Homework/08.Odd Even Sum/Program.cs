using System;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }

            if (even == odd)
            {
                Console.WriteLine($"Yes Sum = {even}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
