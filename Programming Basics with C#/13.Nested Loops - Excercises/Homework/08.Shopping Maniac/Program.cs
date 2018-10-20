using System;
class Program
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int clothesCount = 0;
        int moneySpent = 0;
        while (command != "enough")
        {
            if (command == "enter")
            {
                while (true)
                {
                    if (budget <= 0)
                    {
                        break;
                    }
                    string input = Console.ReadLine();
                    if (input == "leave")
                    {
                        break;
                    }
                    int money = int.Parse(input);
                    if (budget >=money)
                    {
                        moneySpent += money;
                        budget -= money;
                        clothesCount++;
                    }
                    else
                    {
                        Console.WriteLine("Not enough money.");
                    }
                }
            }

            if (budget <= 0)
            {
                break;
            }
            command = Console.ReadLine();
        }

        Console.WriteLine("For {0} clothes I spent {1} lv and have {2} lv left.", clothesCount, moneySpent,budget);
    }
}