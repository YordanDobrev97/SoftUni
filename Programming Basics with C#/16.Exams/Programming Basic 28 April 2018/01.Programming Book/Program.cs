using System;

namespace _01.Programming_Book
{
    class Program
    {
        static void Main()
        {
            double pricePage = double.Parse(Console.ReadLine());
            double priceCover = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double sumPerDesigner = double.Parse(Console.ReadLine());
            double totalDueAmount = double.Parse(Console.ReadLine());

            double price = pricePage * 899 + priceCover * 2;
            price = price - (price * (discount / 100.0));
            
            price += sumPerDesigner;
            price = price - (price * (totalDueAmount / 100.0));

            Console.WriteLine($"Avtonom should pay {price:f2} BGN.");
        }
    }
}
