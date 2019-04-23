using System;

namespace _1.Seaches
{
    public class StartUp
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int numberUsers = int.Parse(Console.ReadLine());
            double moneyPerUserSearch = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numberUsers; i++)
            {
                int wordCount = int.Parse(Console.ReadLine());

                if (wordCount >5)
                {
                    continue;
                }
                else
                {
                    moneyPerUserSearch = wordCount * days;
                }

                if (wordCount == 1)
                {
                    moneyPerUserSearch = (moneyPerUserSearch * 2) * days;
                }

                if (i % 3 == 0)
                {
                    moneyPerUserSearch = (moneyPerUserSearch * 3) * days;
                }                
            }

            Console.WriteLine($"Total money earned for {days} days: {moneyPerUserSearch:f2}");
        }
    }
}
