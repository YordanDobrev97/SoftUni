using System;

class Program
{
    static void Main(string[] args)
    {
        string nameTeam = Console.ReadLine();
        int playedMatches = int.Parse(Console.ReadLine());

        int totalDifferenceGoals = 0;
        int totalPoints = 0;
        for (int i = 0; i < playedMatches; i++)
        {
            int scoredGoals = int.Parse(Console.ReadLine());
            int receivedGoals = int.Parse(Console.ReadLine());
            int difference = scoredGoals - receivedGoals;
            totalDifferenceGoals += difference;
			
            if (scoredGoals > receivedGoals)
            {
                totalPoints += 3;
            }
            else if(scoredGoals == receivedGoals)
            {
                totalPoints += 1;
            }
        }
		
        if (totalDifferenceGoals < 0 || totalPoints == 0)
        {
            Console.WriteLine($"{nameTeam} has been eliminated from the group phase.");
            Console.WriteLine($"Goal difference: {totalDifferenceGoals}.");
        }
        else
        {
            Console.WriteLine($"{nameTeam} has finished the group phase with {totalPoints} points.");
            Console.WriteLine($"Goal difference: {totalDifferenceGoals}.");
        }
    }
}
