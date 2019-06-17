using System;

namespace _01.RageExprenses
{
    class Program
    {
        static void Main()
        {
            int gamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countTrashHeadset = 0;
            int countTrashMouse = 0;
            int countTrashKeyboard = 0;
            int countTrashDisplay = 0;

            for (int game = 1; game <= gamesCount; game++)
            {
                if (game % 2 == 0)
                {
                    countTrashHeadset++;
                }

                if (game % 3 == 0)
                {
                    countTrashMouse++;
                }

                if (game % 2 == 0 && game % 3 == 0)
                {
                    countTrashKeyboard++;

                    if (countTrashKeyboard % 2 == 0)
                    {
                        countTrashDisplay++;
                    }
                }
            }

            double priceOfHeadSet = headsetPrice * countTrashHeadset;
            double priceOfMouse = mousePrice * countTrashMouse;
            double priceOfKeyboard = keyboardPrice * countTrashKeyboard;
            double priceOfDisplay = displayPrice * countTrashDisplay;

            double totalPrice = priceOfHeadSet + priceOfMouse + priceOfKeyboard + priceOfDisplay;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}