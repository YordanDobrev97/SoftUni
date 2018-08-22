using System;

namespace _06.Water_dispenser
{
    class Program
    {
        static void Main()
        {
            int volumeCup = int.Parse(Console.ReadLine());

            int tapped = 1;

            int easyButtonLiters = 50;
            int mediumButtonLiters = 100;
            int hardButtonLiters = 200;

            string button = Console.ReadLine();
            int totalLitters = 0;

            while (true)
            {
                if (button == "Easy")
                {
                    totalLitters += easyButtonLiters;
                }
                else if(button == "Medium")
                {
                    totalLitters += mediumButtonLiters;
                }
                else if(button == "Hard")
                {
                    totalLitters += hardButtonLiters;
                }

                if (totalLitters >= volumeCup)
                {
                    break;
                }

                tapped++;
                button = Console.ReadLine();
            }

            if (totalLitters > volumeCup)
            {
                Console.WriteLine($"{totalLitters - volumeCup}ml has been spilled.");
            }
            else
            {
                Console.WriteLine($"The dispenser has been tapped {tapped} times.");
            }
        }
    }
}
