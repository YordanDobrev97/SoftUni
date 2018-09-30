using System;

namespace _03.Operations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string operatorPerNumber = Console.ReadLine();


            if (secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
                return;
            }
            if (firstNumber == 0)
            {
                Console.WriteLine($"Cannot divide {secondNumber} by zero");
                return;
            }

            if (operatorPerNumber == "+")
            {
                int sum = firstNumber + secondNumber;
                string isEven = sum % 2 == 0 ? "even" : "odd";

                Console.WriteLine($"{firstNumber} + {secondNumber} = {sum} - {isEven}");
            }
            else if (operatorPerNumber == "-")
            {
                int sum = firstNumber - secondNumber;
                string isEven = sum % 2 == 0 ? "even" : "odd";

                Console.WriteLine($"{firstNumber} - {secondNumber} = {sum} - {isEven}");
            }
            else if (operatorPerNumber == "*")
            {
                int sum = firstNumber * secondNumber;
                string isEven = sum % 2 == 0 ? "even" : "odd";

                Console.WriteLine($"{firstNumber} * {secondNumber} = {sum} - {isEven}");
            }
            else if (operatorPerNumber == "/")
            {

                double div = (double)firstNumber / secondNumber;

                Console.WriteLine($"{firstNumber} / {secondNumber} = {div:f2}");

            }
            else if (operatorPerNumber == "%")
            {
                int remainder = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} = {remainder}");
            }
        }
    }
}
