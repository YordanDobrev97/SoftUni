using System;

namespace _05.Cake
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int totalPieces = 0;
            int size = width * length;

            bool isHaveLackingPieces = false;
            while (command != "STOP")
            {
                int piece = int.Parse(command);
                if (totalPieces < size)
                {
                    totalPieces += piece;
                }

                if (totalPieces >= size)
                {
                    isHaveLackingPieces = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isHaveLackingPieces)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", totalPieces - size);
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", size - totalPieces);
            }
        }
    }
}
