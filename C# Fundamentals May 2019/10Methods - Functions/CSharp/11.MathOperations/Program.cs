using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int result = CalcOperations(firstNumber, operation, secondNumber);
            Console.WriteLine(result);

        }
        static int CalcOperations(int firstNumber, string operation, int secondNumber)
        {
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
                default:
                    return 0;
            }
        }
    }
}
