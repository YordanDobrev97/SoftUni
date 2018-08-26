using System;

namespace _04.Building
{
    class Program
    {
        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            

            int last = floors;
            for (int floor = floors; floor >=1; floor--)
            {
                int numberRoom = 0;
                for (int room = 1; room <=rooms; room++)
                {
                    string alhabet = "";
                    if (floor % 2 != 0)
                    {
                        alhabet = "A";
                    }
                    else
                    {
                        alhabet = "O";
                    }
                    if (floor == last)
                    {
                        alhabet = "L";
                    }
                    Console.Write($"{alhabet}{floor}{numberRoom} ");
                    numberRoom++;
                }
                Console.WriteLine();
            }
        }
    }
}
