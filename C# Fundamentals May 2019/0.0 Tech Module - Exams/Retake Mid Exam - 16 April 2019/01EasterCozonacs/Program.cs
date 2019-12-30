using System;

namespace _01EasterCozonacs
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double kg1 = double.Parse(Console.ReadLine());

            double priceEggs = kg1 * 0.75;
            double priceMilk = kg1 + (kg1 * 0.25);
            double needPrice250Ml = (priceMilk * kg1) - priceMilk;

            double total = kg1 + priceEggs + needPrice250Ml;

            int numberEggs = 0;
            int numberCozonac = 0;

            int count = 1;
            while (true)
            {
                if ((budget - total) <=0)
                {
                    break;
                }

                budget -= total;

                numberEggs += 3;
                numberCozonac += 1;

                if (count % 3 == 0)
                {
                    numberEggs = numberEggs - (numberCozonac - 2);
                }
                count++;
            }

            Console.WriteLine($"You made {numberCozonac} cozonacs! Now you have {numberEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
