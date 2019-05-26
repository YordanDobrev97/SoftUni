using System;

namespace _06.TriplesLatinLetters
{
    class TriplesLatinLetters
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + number; i++)
            {
                for (int j = 97; j < 97 + number; j++)
                {
                    for (int k = 97; k < 97 + number; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
