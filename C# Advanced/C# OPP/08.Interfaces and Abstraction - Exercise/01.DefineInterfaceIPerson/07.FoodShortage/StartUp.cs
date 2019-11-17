using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        private const int LengthCitizen = 4;
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] buyerLine = Console.ReadLine().Split();
                BuyerFactory buyer = new BuyerFactory();
                IBuyer result = null;
                if (buyerLine.Length == LengthCitizen)
                {
                    result = buyer.Create(TypeBuyer.Citizen, buyerLine[0], buyerLine[1], buyerLine[2], buyerLine[3]);
                }
                else
                {
                    result = buyer.Create(TypeBuyer.Rebel, buyerLine[0], buyerLine[1], buyerLine[2]);
                }

                buyers.Add(result);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string name = line;

                var currentBuyer = buyers.FirstOrDefault(x => x.Name == name);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }
            }

            var totalFood = buyers.Sum(x => x.Food);
            Console.WriteLine(totalFood);
        }
    }
}
