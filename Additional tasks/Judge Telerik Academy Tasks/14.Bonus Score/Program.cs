using System;

namespace _14.Bonus_Score
{
    class Program
    {
        static void Main()
        {
            double score = double.Parse(Console.ReadLine());

            if (score >= 1 && score <= 9)
            {
                if (score >= 1 && score <= 3)
                {
                    Console.WriteLine(score * 10);
                }
                else if(score >= 4 && score <= 6)
                {
                    Console.WriteLine(score * 100);
                }
                else if(score >= 7 && score <= 9)
                {
                    Console.WriteLine(score * 1000);
                }
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
