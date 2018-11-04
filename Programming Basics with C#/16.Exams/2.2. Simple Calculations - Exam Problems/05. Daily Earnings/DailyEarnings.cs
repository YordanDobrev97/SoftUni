using System;

namespace _05.Daily_Earnings
{
    class DailyEarnings
    {
        static void Main()
        {
            int workDaysInMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double cursor = double.Parse(Console.ReadLine());

            double monthSalary = workDaysInMonth * moneyPerDay;
            double moneyYear = monthSalary * 12 + monthSalary * 2.5;
            double tax = moneyYear * 0.25;
            double netAnnualIncome = moneyYear - tax;
            netAnnualIncome *= cursor;

            double middleSalaryOfDay = netAnnualIncome / 365;
            Console.WriteLine($"{middleSalaryOfDay:f2}");
        }
    }
}
