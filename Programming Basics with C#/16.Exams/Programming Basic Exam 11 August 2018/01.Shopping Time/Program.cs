using System;

namespace _01.Shopping_Time
{
    class Program
    {
        static void Main()
        {
            int timeOfRest = int.Parse(Console.ReadLine());
            double priceOfPeriphery = double.Parse(Console.ReadLine());
            double priceProgram = double.Parse(Console.ReadLine());
            double priceOfFrappe = double.Parse(Console.ReadLine());

            double minutesForFrappe = 5;
            double buyFrappeMinutes = timeOfRest - minutesForFrappe;
            double timeBuyFrappe = 3 * 2;
            double timeBuyProgram = 2 * 2;

            double timeForRelax = buyFrappeMinutes - (timeBuyFrappe + timeBuyProgram);
            double moneyForPeriphery = 3 * priceOfPeriphery;
            double moneyForPrograms = 2 * priceProgram;

            double totalPrice = moneyForPrograms + moneyForPeriphery + priceOfFrappe;
            Console.WriteLine($"{totalPrice:f2}");
            Console.WriteLine($"{timeForRelax}");
        }
    }
}