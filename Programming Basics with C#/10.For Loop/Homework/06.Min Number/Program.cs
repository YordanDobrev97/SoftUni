using System;

namespace _06.Min_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (min > num)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
