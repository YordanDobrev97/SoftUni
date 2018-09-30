using System;

namespace _04.Hotel_Room
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int numberNight = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartament = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartament = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartament = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartament = 77;
                    break;
            }

            double percentageStudio = 0;
            if (numberNight > 7 && numberNight < 14 && (month == "May" || month == "October"))
            {
                percentageStudio = priceStudio * 0.05;
            }
            else if(numberNight > 14 && (month == "May" || month == "October"))
            {
                percentageStudio = priceStudio * 0.30;
            }
            else if(numberNight > 14 && (month == "June" || month == "September"))
            {
                percentageStudio = priceStudio * 0.20;
            }

            double percentageApartament = 0;
            if (numberNight > 14)
            {
                percentageApartament = priceApartament * 0.10;
            }

            priceStudio -= percentageStudio;
            priceStudio *= numberNight;


            priceApartament -= percentageApartament;
            priceApartament *= numberNight;

            Console.WriteLine("Apartment: {0:f2} lv.", priceApartament);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
