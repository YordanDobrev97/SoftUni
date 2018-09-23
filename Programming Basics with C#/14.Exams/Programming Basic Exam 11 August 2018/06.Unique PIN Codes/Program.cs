using System;

namespace _06.Unique_PIN_Codes
{
    class Program
    {
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            for (int i1 = 2; i1 <=firstNumber; i1++)
            {
                for (int i2 = 2; i2 <=secondNumber; i2++)
                {
                    for (int i3 = 2; i3 <=thirdNumber; i3++)
                    {
                        if (IsEven(i1) && IsEven(i3) && IsPrime(i2))
                        {
                            Console.WriteLine($"{i1} {i2} {i3}");
                        }
                    }
                }
            }
        }
    }
}
