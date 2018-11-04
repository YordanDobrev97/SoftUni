using System;

namespace _06.Sum_And_Product
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <=9; a++)
            {
                for (int b = 9; b >=a; b--)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 9; d >=c; d--)
                        {
                            int sum = a + b + c + d;
                            int product = a * b * c * d;
                            if (sum == product && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }
                            else if(product / sum == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
