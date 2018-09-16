using System;

namespace _02.Scholarship
{
    //93 / 100
    class Program
    {
        static void Main()
        {
            double leva = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalWorkSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minimalWorkSalary * 0.35;
            double averageSuccsessScholarship = averageSuccess * 25;

            if (averageSuccess < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                if (averageSuccess >= 5.50)
                {
                    if (socialScholarship > averageSuccsessScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(averageSuccsessScholarship)} BGN");
                    }
                }
                else if(minimalWorkSalary > leva && averageSuccess >= 4.50)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
