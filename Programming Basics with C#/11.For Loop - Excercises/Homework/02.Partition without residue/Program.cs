using System;

namespace _02.Partition_without_residue
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    p1++;
                }

                if (currentNumber % 3 == 0)
                {
                    p2++;
                }
                if (currentNumber % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", p1 / number * 100.00);
            Console.WriteLine("{0:f2}%", p2 / number * 100.00);
            Console.WriteLine("{0:f2}%", p3 / number * 100.00);
        }
    }
}
