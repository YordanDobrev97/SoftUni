using System;

namespace Conditions
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("Bigger number is: {0}", b);
            }
            else
            {
                Console.WriteLine("Bigger number is: {0}", a);
            }
        }
    }
}
