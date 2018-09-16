using System;

namespace _03.Choreography
{
    class Program
    {
        static void Main()
        {
            double numberStep = double.Parse(Console.ReadLine());
            double numberDancers = double.Parse(Console.ReadLine());
            double numberDaysForLearning = double.Parse(Console.ReadLine());

            double stepPerDay = (numberStep / numberDaysForLearning) / numberStep;
            stepPerDay = Math.Ceiling(stepPerDay * 100);


            if (stepPerDay <= 13)
            {
                double percent = stepPerDay / numberDancers;
                Console.WriteLine($"Yes, they will succeed in that goal! {percent:f2}%.");
            }
            else
            {
                double percent = Math.Ceiling((stepPerDay * 100) / numberDancers);
                Console.WriteLine($"No, They will not succeed in that goal! Required {percent / 100:f2}% steps to be learned per day.");
            }
        }
    }
}
