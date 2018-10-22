using System;
class Program
{
    static void Main()
    {
        int fishCount = int.Parse(Console.ReadLine());

        bool isDailyQuota = false;
        double loseMoney = 0;
        double earnedMoney = 0;

        int count = 1;
        int countFish = 0;
        while (true)
        {
            string nameFish = Console.ReadLine();
            if (nameFish == "Stop")
            {
                break;
            }
            double killosFish = double.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < nameFish.Length; i++)
            {
                sum += nameFish[i];
            }
            double price = sum / killosFish;

            if (count % 3 == 0)
            {
                earnedMoney += price;
            }
            else
            {
                loseMoney += price;
            }

            countFish++;
            if (count == fishCount)
            {
                isDailyQuota = true;
                break;
            }
            count++;
            
        }

        if (isDailyQuota)
        {
            Console.WriteLine("Lyubo fulfilled the quota!");
        }

        if (earnedMoney >= loseMoney)
        {
            Console.WriteLine($"Lyubo's profit from {countFish} fishes is {(earnedMoney - loseMoney):f2} leva.");
        }
        else
        {
            Console.WriteLine($"Lyubo lost {(loseMoney - earnedMoney):f2} leva today.");
        }
    }
}