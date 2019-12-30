using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();

            foreach (var item in input)
            {
                int numberValue = item;
                numberValue += 3;

                char currentSymbol = (char)numberValue;
                text.Append(currentSymbol);
            }

            Console.WriteLine(text);
        }
    }
}
