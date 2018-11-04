using System;
namespace _05.Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGuest = int.Parse(Console.ReadLine());
            int numberGifts = int.Parse(Console.ReadLine());

            double countMoney = 0;
            double countElectricalAppliances = 0;
            double countVouchers = 0;
            double countOthers = 0;
            for (int i = 0; i < numberGifts; i++)
            {
                string category = Console.ReadLine();
                //"A", "B", "V" и "G".
                switch (category)
                {
                    case "A":
                        countMoney++;
                        break;
                    case "B":
                        countElectricalAppliances++;
                        break;
                    case "V":
                        countVouchers++;
                        break;
                    case "G":
                        countOthers++;
                        break;
                }
            }

            Console.WriteLine($"{countMoney / numberGifts * 100.00:f2}%");
            Console.WriteLine($"{countElectricalAppliances / numberGifts * 100.00:f2}%");
            Console.WriteLine($"{countVouchers / numberGifts * 100.00:f2}%");
            Console.WriteLine($"{countOthers / numberGifts * 100.00:f2}%");
            Console.WriteLine($"{(double)numberGifts / numberGuest * 100.00:f2}%");
        }
    }
}
