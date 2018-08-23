using System;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
