using System;

class ChristmasSpirit
{
    static void Main()
    {
        int quantity = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int totalCost = 0;
        int totalSpirit = 0;

        int ornamentSetPrice = 2;
        int treeSkirtPrice = 5;
        int treeGarlandsPrice = 3;
        int treeLightsPrice = 15;

        for (int day = 1; day <=days; day++)
        {
            if (day % 2 == 0)
            {
                //buy an Ornament Set 
                totalSpirit += 5;
                totalCost += ornamentSetPrice;
            }

            if (day % 3 == 0)
            {
                //buy Tree Skirts and Tree Garlands 
                totalCost += treeSkirtPrice;
                totalCost += treeGarlandsPrice;
                totalSpirit += 13;
            }

            if (day % 5 == 0)
            {
                //buy Tree Lights 
                totalCost += treeLightsPrice;
                totalSpirit += 17;


                if (day % 3 == 0)
                {
                    //buy Tree Skirts and Tree Garlands 
                    totalCost += treeSkirtPrice;
                    totalCost += treeGarlandsPrice;
                    totalSpirit += 30;
                }
            }

            if (day % 10 == 0)
            {
                //lose 20 spirit
                totalSpirit -= 20;
            }

            if (day % 11 == 0)
            {
                //increase the allowed quantity with 2 at the beginning of every eleventh day.
                totalCost += 2;
            }
        }

        if (days == 10)
        {
            //lose additional 30 spirit.
            totalSpirit -= 30;
        }

        Console.WriteLine($"Total cost: {totalCost}");
        Console.WriteLine($"Total spirit: {totalSpirit}");
    }
}

