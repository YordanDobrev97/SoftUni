using System;

namespace _05.PrintPartASCIITable
{
    class PrintPartASCIITable
    {
        static void Main()
        {
            int startAsciiNumber = int.Parse(Console.ReadLine());
            int endAsciiNumber = int.Parse(Console.ReadLine());

            char startSymbol = (char)(startAsciiNumber);
            char endSymbol = (char)(endAsciiNumber);

            for (char i = startSymbol; i <=endSymbol; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
