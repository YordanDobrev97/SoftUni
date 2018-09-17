using System;

namespace _03.Game_Statistics
{
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
                Console.WriteLine("{0} missed a penalty.", namePlayer);
                if (minutes % 2 == 0)
                {
                    Console.WriteLine("{0} was injured after the penalty.", namePlayer);
                }
            }
            else if(minutes > 10 && minutes <= 35)
            {
                Console.WriteLine("{0} received yellow card.", namePlayer);
                if (minutes % 2 == 1)
                {
                    Console.WriteLine("{0} got another yellow card.", namePlayer);
                }
            }
            else if (minutes > 45 && minutes < 45)
            {
                Console.WriteLine("{0} SCORED A GOAL !!!", namePlayer);
            }
            else if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine("{0} got a freekick.", namePlayer);

                if (minutes % 2 == 0)
                {
                    Console.WriteLine("{0} missed the freekick.", namePlayer);
                }
            }
            else if(minutes > 55 && minutes <= 80)
            {
                Console.WriteLine("{0} missed a shot from corner.",namePlayer);

                if (minutes % 2 == 1)
                {
                    Console.WriteLine("{0} has been changed with another player.", namePlayer);
                }
            }
            else if(minutes > 80 && minutes <= 90)
            {
                Console.WriteLine("{0} SCORED A GOAL FROM PENALTY !!!", namePlayer);
            }
        }
    }
}
