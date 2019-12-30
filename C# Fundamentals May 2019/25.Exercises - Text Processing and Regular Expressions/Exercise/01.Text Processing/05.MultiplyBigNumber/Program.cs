using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber[0] == '0')
            {
                Console.WriteLine(0);
                return;
            }

            int length = firstNumber.Length;

            StringBuilder productNumbers = new StringBuilder();
            int remainder = 0;
            for (int i = 0; i < length; i++)
            {
                int lastDigit = firstNumber[firstNumber.Length - 1 - i] - '0';

                int result = lastDigit * secondNumber;

                productNumbers.Append((result % 10) + remainder);

                if (result >=10)
                {
                    remainder = result / 10;
                }
                
            }

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
            }
            else if (remainder > 0)
            {
                productNumbers.Append(remainder);

                var number = productNumbers.ToString().Reverse();

                Console.WriteLine(string.Join("", number));
            }
        }
    }
}
