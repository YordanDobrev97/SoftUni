using System;
class Program
{
    static void Main()
    {
        int minutes = int.Parse(Console.ReadLine());
        string namePlayer = Console.ReadLine();

        if (minutes == 0)
        {
            Console.WriteLine("Match has just began!");
        }
        else if(minutes < 45)
        {
            Console.WriteLine("First half time.");
        }
        else
        {
            Console.WriteLine("Second half time.");
        }

        if (minutes >= 1 && minutes <= 10)
        {
            Console.WriteLine($"{namePlayer} missed a penalty.");
            if (minutes % 2 == 0)
            {
                Console.WriteLine($"{namePlayer} was injured after the penalty.");
            }
        }
        else if(minutes > 10 && minutes <= 35)
        {
            Console.WriteLine($"{namePlayer} received yellow card.");

            if (minutes % 2 == 1)
            {
                Console.WriteLine($"{namePlayer} got another yellow card.");
            }
        }
        else if(minutes > 35 && minutes < 45)
        {
            Console.WriteLine($"{namePlayer} SCORED A GOAL !!!");
        }
        else if(minutes > 45 && minutes <= 55)
        {
            Console.WriteLine($"{namePlayer} got a freekick.");

            if (minutes % 2 == 0)
            {
                Console.WriteLine($"{namePlayer} missed the freekick.");
            }
        }
        else if(minutes > 55 && minutes <= 80)
        {
            Console.WriteLine($"{namePlayer} missed a shot from corner.");

            if (minutes % 2 == 1)
            {
                Console.WriteLine($"{namePlayer} has been changed with another player.");
            }
        }
        else if(minutes > 80 && minutes <= 90)
        {
            Console.WriteLine($"{namePlayer} SCORED A GOAL FROM PENALTY !!!");
        }
    }
}

