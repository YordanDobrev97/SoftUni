using System;
using System.Collections.Generic;
using System.Linq; 
     
namespace _12.Odd_Even_Position
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            for (int i = 1; i <=n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                OddPosition(ref oddSum, ref oddMin, ref oddMax, i, num);
                EvenPosition(ref evenSum, ref evenMin, ref evenMax, i, num);
            }

            string oddMinOutput = oddMin + "";
            if (oddMin == int.MaxValue)
            {
                oddMinOutput = "No";
            }

            string oddMaxOutput = oddMax + "";
            if (oddMax == int.MinValue)
            {
                oddMaxOutput = "No";
            }

            string evenMinOutput = evenMin + "";
            if (evenMin == int.MaxValue)
            {
                evenMinOutput = "No";
            }

            string evenMaxOutput = evenMax + "";
            if (evenMax == int.MinValue)
            {
                evenMaxOutput = "No";
            }

            Console.WriteLine($"OddSum={oddSum},");
            Console.WriteLine($"OddMin={oddMinOutput},");
            Console.WriteLine($"OddMax={oddMaxOutput},");

            Console.WriteLine($"EvenSum={evenSum},");
            Console.WriteLine($"EvenMin={evenMinOutput},");
            Console.WriteLine($"EvenMax={evenMaxOutput}");
        }

        private static void EvenPosition(ref double evenSum, ref double evenMin, ref double evenMax, int i, double num)
        {
            if (i % 2 == 0)
            {
                evenSum += num;
            }

            if (i % 2 == 0 && evenMin > num)
            {
                evenMin = num;
            }

            if (i % 2 == 0 && evenMax < num)
            {
                evenMax = num;
            }
        }

        private static void OddPosition(ref double oddSum, ref double oddMin, ref double oddMax, int i, double num)
        {
            if (i % 2 == 1)
            {
                oddSum += num;
            }

            if (i % 2 == 1 && oddMin > num)
            {
                oddMin = num;
            }

            if (i % 2 == 1 && oddMax < num)
            {
                oddMax = num;
            }
        }
    }
}
