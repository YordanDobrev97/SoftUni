using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main()
        {
            string projection = Console.ReadLine();
            int numberRows = int.Parse(Console.ReadLine());
            int numberCols = int.Parse(Console.ReadLine());

            double price = 0;
            if (projection == "Premiere")
            {
                price = 12;
            }
            else if(projection == "Normal")
            {
                price = 7.50;
            }
            else
            {
                price = 5;
            }

            Console.WriteLine($"{price * numberRows * numberCols:f2} leva");
        }
    }
}
