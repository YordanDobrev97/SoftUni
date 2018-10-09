using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetCount = 0;
            int trashedMouseCount = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <=lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsetCount++;
                }

                if (i % 3 == 0)
                {
                    trashedMouseCount++;
                }

                if (i % 6 == 0)
                {
                    trashedKeyboard++;
                }

                if (i % 12 == 0)
                {
                    trashedDisplay++;
                }
            }

            double totalCost = trashedHeadsetCount * headsetPrice + 
                trashedMouseCount * mousePrice +
                trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;


            Console.WriteLine("Rage expenses: {0:f2} lv.", totalCost);
        }
    }
}
