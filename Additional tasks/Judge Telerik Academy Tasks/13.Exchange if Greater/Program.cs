using System;

namespace _13.Exchange_if_Greater
{
    class Program
    {
        static void Main()
        {
            double firstValue = double.Parse(Console.ReadLine());
            double secondValue = double.Parse(Console.ReadLine());

            if (firstValue > secondValue)
            {
                double temp = firstValue;
                firstValue = secondValue;
                secondValue = temp;
            }

            Console.WriteLine($"{firstValue} {secondValue}");
        }
    }
}
