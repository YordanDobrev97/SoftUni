using System;

namespace _08.Travelling
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var distance = Console.ReadLine();
                if (distance == "End")
                {
                    return;
                }
                var minimalBudget = double.Parse(Console.ReadLine());
                var currentBudget = 0.0;
                while (currentBudget < minimalBudget)
                {
                    var budget = Console.ReadLine();
                    if (budget == "End")
                    {
                        return;
                    }
                    try
                    {
                        currentBudget += double.Parse(budget);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Catch");
                    }
                    
                }

                if (currentBudget >= minimalBudget)
                {
                    Console.WriteLine($"Going to {distance}!");
                }
            }
        }
    }
}
