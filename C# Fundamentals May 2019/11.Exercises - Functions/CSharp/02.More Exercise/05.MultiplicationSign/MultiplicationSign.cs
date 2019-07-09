using System;

namespace _05.MultiplicationSign
{
    public class MultiplicationSign
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());

            string message = string.Empty;

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                message = "zero";
            }
            else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) 
                || (secondNumber < 0 && thirdNumber < 0 && firstNumber > 0)
                || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
                || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0))
            {
                message = "positive";
            }
            else
            {
                message = "negative";
            }

            Console.WriteLine(message);
        }
    }
}
