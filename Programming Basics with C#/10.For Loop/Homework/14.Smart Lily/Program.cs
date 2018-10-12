using System;

namespace _14.Smart_Lily
{
    class Program
    {
        static void Main()
        {
            double moneyForBirthday = 10.00;

            int ageLily = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            double sumMoneyPerEvenAge = 0;
            double totalSum = 0;
            int countToys = 0;
            int brother = 0;
            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoneyPerEvenAge += moneyForBirthday;
                    totalSum += sumMoneyPerEvenAge;
                    brother++;
                }
                else
                {
                    countToys++;
                }
            }

            double priceToys = countToys * priceToy;
            double result = totalSum + priceToys - brother;

            if (result >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {result - priceWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - result:f2}");
            }
        }
    }
}
