using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string str = "I love programming";
            char[] symbols = str.ToCharArray();

            foreach (var symbol in symbols)
            {
                Console.WriteLine(symbol);
            }

            Console.WriteLine("Sub-string: ");
            string text = str.Substring(7);
            Console.WriteLine(text);
        }
    }
}
