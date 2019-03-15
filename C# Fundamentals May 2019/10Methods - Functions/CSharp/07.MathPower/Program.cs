using System;

namespace _07.MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = PowerNumber(number, power);
            Console.WriteLine(result);
        }
        static double PowerNumber(double firstNumber, double power)
        {
            return Math.Pow(firstNumber, power);
        }
    }
}
