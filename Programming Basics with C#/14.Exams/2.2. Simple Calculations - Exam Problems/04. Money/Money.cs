using System;

namespace _04.Money
{
    class Money
    {
        static void Main()
        {
            int numberOfBitcoins = int.Parse(Console.ReadLine());
            double numberYuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            commission /= 100;

            int bitcoin = 1168;
            double chineseYuan = 0.15;
            double dolar = 1.76;
            double euro = 1.95;

            double leva = numberOfBitcoins * bitcoin;
            double yuans = numberYuans * chineseYuan;
            double dolars = yuans * dolar;

            leva += dolars;
            leva /= euro;

            commission *= leva;

            double result = leva - commission;

            Console.WriteLine(result);
        }
    }
}
