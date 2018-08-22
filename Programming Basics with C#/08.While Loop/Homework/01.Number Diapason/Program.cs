using System;

namespace _01.Number_Diapason
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (!(number >= 1 && number <= 100))
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}",number);
        }
    }
}
