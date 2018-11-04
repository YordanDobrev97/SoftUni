using System;

namespace _04.Credit_System
{
    class Program
    {
        static void Main()
        {
            int numberCoursesRecord = int.Parse(Console.ReadLine());

            double percent = 0;
            double averageGrade = 0.0;
            double numberCredit = 0.0;
            for (int i = 0; i < numberCoursesRecord; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                int grade = digits % 10;
                averageGrade += grade;
                digits /= 10;
                int numberCredits = digits;

                if (grade == 2)
                {
                    percent = 0;
                }
                else if (grade == 3)
                {
                    percent = numberCredits * 0.50;
                }
                else if(grade == 4)
                {
                    percent = numberCredits * 0.70;
                }
                else if(grade == 5)
                {
                    percent = numberCredits * 0.85;
                }
                else if(grade == 6)
                {
                    percent = numberCredits;
                }
                numberCredit += percent;
            }
            Console.WriteLine($"{numberCredit:f2}");
            Console.WriteLine($"{averageGrade / numberCoursesRecord:f2}");
        }
    }
}
