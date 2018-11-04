using System;

namespace _02.Cat_Shirt
{
    class Program
    {
        static void Main()
        {
            double sizeSleeve = double.Parse(Console.ReadLine());
            double sizeFrontPart = double.Parse(Console.ReadLine());
            string fabric = Console.ReadLine().ToLower();
            string tie = Console.ReadLine().ToLower();

            double sizeInCentimeters = sizeSleeve * 2 + 
                sizeFrontPart * 2;
            sizeInCentimeters = sizeInCentimeters + (sizeInCentimeters * 0.10);

            double priceFabric = 0.0;

            if (fabric == "linen")
            {
                priceFabric = 15;
            }
            else if(fabric == "cotton")
            {
                priceFabric = 12;
            }
            else if(fabric == "denim")
            {
                priceFabric = 20;
            }
            else if(fabric == "twill")
            {
                priceFabric = 16;
            }
            else
            {
                priceFabric = 11;
            }

            sizeInCentimeters /= 100;
            sizeInCentimeters *= priceFabric;
            sizeInCentimeters += 10;

            if (tie == "yes")
            {
                sizeInCentimeters = sizeInCentimeters + (sizeInCentimeters * 0.20);
            }

            Console.WriteLine($"The price of the shirt is: {sizeInCentimeters:f2}lv.");
        }
    }
}
