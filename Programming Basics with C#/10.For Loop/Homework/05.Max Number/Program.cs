using System;

namespace _05.Max_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (max < num)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
