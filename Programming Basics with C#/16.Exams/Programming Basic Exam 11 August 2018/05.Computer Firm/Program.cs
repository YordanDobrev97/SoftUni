using System;

namespace _05.Computer_Firm
{
    class Program
    {
        static void Main()
        {
            int numberComputers = int.Parse(Console.ReadLine());

            double totalSales = 0;
            double totalRating = 0;

            for (int i = 0; i < numberComputers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int rating = number % 10;
                totalRating += rating;
                number /= 10;
                int sales = number;

                if (rating == 3)
                {
                    totalSales += sales * 0.5;
                }
                else if (rating == 4)
                {
                    totalSales += sales * 0.7;
                }
                else if(rating == 5)
                {
                    totalSales += sales * 0.85;
                }
                else if(rating == 6)
                {
                    totalSales += sales;
                }
            }
            Console.WriteLine("{0:f2}",totalSales);
            Console.WriteLine("{0:f2}",totalRating / numberComputers);
        }
    }
}
