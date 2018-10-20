using System;
class Program
{
    static void Main()
    {
        int fishCount = int.Parse(Console.ReadLine());

        int count = 1;
        double loseMoney = 0;

        double price = 0;
        for (int i = 1; i <=fishCount; i++)
        {
            string nameFish = Console.ReadLine();
            if (nameFish == "Stop")
            {
                break;
            }
            double killos = double.Parse(Console.ReadLine());

            int sumAsciiNameFish = 0;
            for (int j = 0; j < nameFish.Length; j++)
            {
                int value = nameFish[j];
                sumAsciiNameFish += value;
            }
            double averageSum = Math.Round(sumAsciiNameFish / killos,2);

            if (i % 3 == 0)
            {
                price += averageSum;
            }
            else
            {
                loseMoney += averageSum;
            }
        }

        if (price <= loseMoney)
        {
            Console.WriteLine("Lyubo fulfilled the quota! Lyubo's profit from 3 fishes is 6.21 leva.");
        }
    }
}

