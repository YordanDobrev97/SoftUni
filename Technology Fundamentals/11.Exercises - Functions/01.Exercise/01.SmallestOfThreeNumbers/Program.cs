using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine()); //2 
            int secondNumber = int.Parse(Console.ReadLine()); //3
            int thirdNumber = int.Parse(Console.ReadLine()); // -1

            int currentMin = Min(firstNumber, secondNumber); // 2
            int min = Min(currentMin, thirdNumber);

            Console.WriteLine(min);

        }
        public static int Min(int firstNumber, int secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        }
    }
}
