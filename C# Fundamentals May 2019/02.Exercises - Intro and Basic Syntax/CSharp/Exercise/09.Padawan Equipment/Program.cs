using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            double numberLightsabers = double.Parse(Console.ReadLine());
            double numberRobes = double.Parse(Console.ReadLine());
            double numberBelts = double.Parse(Console.ReadLine());

            double discountStudents = Math.Ceiling(numberStudents + (numberStudents * 0.10));
            double lightsabersPrice = numberLightsabers * discountStudents;
            double robesPrice = numberRobes * numberStudents;
            double discountBelts = numberStudents - numberStudents / 6;
            double beltsPrice = numberBelts * discountBelts;

            double price = lightsabersPrice + robesPrice + beltsPrice;

            if (price <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {price - amountMoney:f2}lv more.");
            }
        }
    }
}
