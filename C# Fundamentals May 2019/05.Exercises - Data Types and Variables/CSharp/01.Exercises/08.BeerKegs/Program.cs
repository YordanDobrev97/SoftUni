using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main()
        {
            int beerKegs = int.Parse(Console.ReadLine());

            string biggestKeg = string.Empty;
            double maxVolume = 0;
            for (int i = 0; i < beerKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = modelKeg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
