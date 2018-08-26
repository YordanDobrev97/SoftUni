using System;

namespace _03.Even_Powers_of_2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int power = 1;
            Console.WriteLine(power);
            for (int i = 1; i < n; i+=2)
            {
                power *= 4;
                Console.WriteLine(power);
            }
        }
    }
}
