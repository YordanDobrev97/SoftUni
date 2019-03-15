using System;

namespace _05.AddSubtract
{
    public class AddSubtract
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Add(firstNumber, secondNumber);
            int resultSum = Subtract(sum, thirdNumber);
            Console.WriteLine(resultSum);
        }
        public static int Add(int first, int second)
        {
            return first + second;
        }
        public static int Subtract(int first, int second)
        {
            return first - second;
        }
    }
}
