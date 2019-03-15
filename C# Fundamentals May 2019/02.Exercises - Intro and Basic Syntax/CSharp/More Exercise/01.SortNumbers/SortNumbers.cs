using System;
using System.Linq;

namespace _01.SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[3];
            numbers[0] = firstNumber;
            numbers[1] = secondNumber;
            numbers[2] = thirdNumber;

            
            foreach (var number in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(number);
            }
        }
    }
}
