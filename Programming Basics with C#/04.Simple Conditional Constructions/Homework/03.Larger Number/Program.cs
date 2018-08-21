using System;

namespace _03.Larger_Number
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int largeNumber = firstNumber;

            if (secondNumber > firstNumber)
            {
                largeNumber = secondNumber;
            }

            Console.WriteLine("Large number: {0}",largeNumber);
        }
    }
}
