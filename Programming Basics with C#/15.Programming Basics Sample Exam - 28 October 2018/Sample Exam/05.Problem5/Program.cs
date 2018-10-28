using System;

class Program
{
    static void Main()
    {
        int travelers = int.Parse(Console.ReadLine());
        int numberOfStops = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStops; i++)
        {
            int goinDown = int.Parse(Console.ReadLine());
            int pickUp = int.Parse(Console.ReadLine());

            travelers = travelers - goinDown + pickUp;
            if (i % 2 == 0)
            {
                travelers += 2;
            }
            else
            {
                travelers -= 2;
            }
        }
        Console.WriteLine($"The final number of passengers is : {travelers}");
    }
}

