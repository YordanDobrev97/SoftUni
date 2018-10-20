using System;
class Program
{
    static void Main()
    {
        int juryCount = int.Parse(Console.ReadLine());

        double totalGrade = 0;
        int count = 0;
        while (true)
        {
            string presentaion = Console.ReadLine();
            if (presentaion == "Finish")
            {
                break;
            }

            double sumGrade = 0;
            for (int i = 0; i < juryCount; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                sumGrade += grades;
                totalGrade += grades;
                count++;
            }
            Console.WriteLine($"{presentaion} - {sumGrade / juryCount:f2}.");
        }
        Console.WriteLine($"Student's final assessment is {totalGrade / count:f2}.");
    }
}

