using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int numberDays = 0;
            bool isSuccessivelyDays = false;
            while (money < neededMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    if (sum > money)
                    {
                        money = 0;
                    }
                    else
                    {
                        money -= sum;
                    }
                    isSuccessivelyDays = true;
                }
                else if(action == "save")
                {
                    money += sum;
                    isSuccessivelyDays = false;
                }
                numberDays++;

                if (isSuccessivelyDays && numberDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(numberDays);
                    return;
                }
            }

            if (money >=0)
            {
                Console.WriteLine($"You saved the money for {numberDays} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(numberDays);
            }
        }
    }
}
