using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = 0;
            switch (operation)
            {
                case "add":
                    result = Add(firstNumber, secondNumber);
                    break;
                case "subtract":
                    result = Subtract(firstNumber, secondNumber);
                    break;
                case "multiply":
                    result = Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    result = Divide(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine(result);
        }
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
