using System;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main()
        {
            int unsatisfactoryGrades = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int currentNumberUnsatisfactoryАssessments = 0;
            int numberOfProblems = 0;
            string lastProblem = string.Empty;
            double sum = 0;

            bool isEnough = true;
            while (command != "Enough")
            {
                numberOfProblems++;
                string nameTask = command;
                lastProblem = nameTask;

                int grade = int.Parse(Console.ReadLine());
                sum += grade;
                if (grade <= 4)
                {
                    currentNumberUnsatisfactoryАssessments++;
                }

                if (currentNumberUnsatisfactoryАssessments == unsatisfactoryGrades)
                {
                    isEnough = false;
                    break;
                }
                command = Console.ReadLine();
            }

            if (isEnough)
            {
                Console.WriteLine($"Average score: {sum / numberOfProblems:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {unsatisfactoryGrades} poor grades.");
            }
        }
    }
}
