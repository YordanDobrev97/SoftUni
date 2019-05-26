using System;

namespace _03.FloatingEquality
{
    public class FloatingEquality
    {
        public static void Main()
        {
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());

            float epsilon = 0.000001f;

            float max = Math.Max(firstNumber, secondNumber) - epsilon;
            float min = Math.Min(firstNumber, secondNumber) - epsilon;

            float diff = Math.Abs(max - min);
            var result = diff <= epsilon;

            Console.WriteLine(result);
        }
    }
}
