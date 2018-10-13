using System;
namespace _01.Histogram
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber <200)
                {
                    p1++;
                }
                else if (currentNumber >=200 && currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber >=400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >=600 && currentNumber <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine("{0:f2}%", p1 / number * 100.00);
            Console.WriteLine("{0:f2}%", p2 / number * 100.00);
            Console.WriteLine("{0:f2}%", p3 / number * 100.00);
            Console.WriteLine("{0:f2}%", p4 / number * 100.00);
            Console.WriteLine("{0:f2}%", p5 / number * 100.00);
        }
    }
}
