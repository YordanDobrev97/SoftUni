using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main()
        {
            int maxLetters = 255;

            int number = int.Parse(Console.ReadLine());

            int maxQuantity = 0;
            for (int i = 0; i < number; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                int totalQuantity = maxQuantity + quantity;

                if (totalQuantity > maxLetters)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    maxQuantity += quantity;
                }
            }

            Console.WriteLine(maxQuantity);
        }
    }
}
