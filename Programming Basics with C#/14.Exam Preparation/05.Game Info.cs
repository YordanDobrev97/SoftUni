using System;
class Program
{
    static void Main()
    {
        string teamName = Console.ReadLine();
        int matches = int.Parse(Console.ReadLine());

        int totalTime = 0;
        int additionalTime = 0;
        int penalties = 0;

        for (int i = 0; i < matches; i++)
        {
            int time = int.Parse(Console.ReadLine());
            totalTime += time;

            if (time > 120)
            {
                penalties++;
            }
            else if (time > 90)
            {
                additionalTime++;
            } 
        }

        double average = (double)totalTime / matches;
        Console.WriteLine($"{teamName} has played {totalTime} minutes. Average minutes per game: {average:f2}");
        Console.WriteLine($"Games with penalties: {penalties}");
        Console.WriteLine($"Games with additional time: {additionalTime}");
    }
}
