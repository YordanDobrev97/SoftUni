using System;
class Program
{
    static void Main()
    {
        int numberSectors = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        double ticketPrice = double.Parse(Console.ReadLine());

        double totalIncome = capacity * ticketPrice;
        double incomePerSector = totalIncome / numberSectors;

        double moneyForCharity = (totalIncome - (incomePerSector * 0.75)) / 8;

        Console.WriteLine($"Total income - {totalIncome:f2} BGN");
        Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
    }
}
