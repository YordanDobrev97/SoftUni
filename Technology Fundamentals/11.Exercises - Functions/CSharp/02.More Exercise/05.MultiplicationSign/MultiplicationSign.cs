using System;

namespace _05.MultiplicationSign
{
    public class MultiplicationSign
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (HasNegativeNumber(firstNumber)
                || HasNegativeNumber(secondNumber)
                || HasNegativeNumber(thirdNumber))
            {
                PrintMessage("negative");
            }
            else
            {
                PrintMessage("positive");
            }
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static bool HasNegativeNumber(int firstNumber)
        {
            return firstNumber < 0;
        }
    }
}
