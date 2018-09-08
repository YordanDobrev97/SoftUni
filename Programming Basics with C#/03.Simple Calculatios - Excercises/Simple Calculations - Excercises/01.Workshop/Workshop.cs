using System;

namespace _01.Workshop
{
    class Workshop
    {
        private const double priceRectangleCover = 7;
        private const double pricePerBox = 9;
        private const double cursorPerDollar = 1.85;
        private const double cover = 0.30;

        static void Main()
        {
            int numberRectangularTables = int.Parse(Console.ReadLine());
            double lengthPerRectangleTablesMeters = double.Parse(Console.ReadLine());
            double widthPerRectangleTabelsMeters = double.Parse(Console.ReadLine());

            double totalAreaPerCover = numberRectangularTables * (lengthPerRectangleTablesMeters + 2 * cover) * (widthPerRectangleTabelsMeters + 2 * cover);
            double totalAreaPerBox = numberRectangularTables * (lengthPerRectangleTablesMeters / 2) * (lengthPerRectangleTablesMeters / 2);
            double priceInDollars = totalAreaPerCover * priceRectangleCover + totalAreaPerBox * pricePerBox;
            double priceInLeva = priceInDollars * cursorPerDollar;

            Console.WriteLine($"{priceInDollars:f2} USD");
            Console.WriteLine($"{priceInLeva:f2} BGN");
        }
    }
}
