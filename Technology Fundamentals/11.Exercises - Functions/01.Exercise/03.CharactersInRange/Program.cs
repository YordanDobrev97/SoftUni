using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            CharactersInRange(firstSymbol, secondSymbol);
        }
        public static void CharactersInRange(char firstSymbol, char secondSymbol)
        {
            var minSymbol = Math.Min(firstSymbol, secondSymbol);
            var maxSymbol = Math.Max(firstSymbol, secondSymbol);
            for (int i = minSymbol + 1; i < maxSymbol; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
