using System;

namespace _06.Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberRowFirstSector = int.Parse(Console.ReadLine());
            int numberOddRow = int.Parse(Console.ReadLine());

            char currentSymbol = 'a';
            for (char i = 'A'; i <=lastSector; i++)
            {
                for (int second = 1; second < numberRowFirstSector; second++)
                {
                    if (second % 2 == 0)
                    {
                        for (char third = 'a'; third <='d'; third++)
                        {
                            Console.WriteLine($"{i}{second}{third}");
                        }
                    }
                    else
                    {
                        for (char third = 'a'; third <='b'; third++)
                        {
                            Console.WriteLine($"{i}{second}{third}");
                        }
                    }
                }
            }
        }
    }
}
