using System;

namespace _02.Grades
{
    class Program
    {
        private static string messageForWeakGrade = "Fail";
        private static string messageForPoorGrade = "Poor";
        private static string messageForGoodGrade = "Good";
        private static string messageForVeryGoodGrade = "Very good";
        private static string messageForExcellent = "Excellent";

        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            CheckGrade(grade);
        }
        static void CheckGrade(double grade)
        {
            if (grade >= 2 && grade <= 2.99)
            {
                PrintMessage(messageForWeakGrade);
            }
            else if(grade >= 3 && grade <= 3.49)
            {
                PrintMessage(messageForPoorGrade);
            }
            else if(grade >= 3.50 && grade <= 4.49)
            {
                PrintMessage(messageForGoodGrade);
            }
            else if(grade > 4.49 && grade <= 5.49)
            {
                PrintMessage(messageForVeryGoodGrade);
            }
            else if(grade > 5.49 && grade <= 6)
            {
                PrintMessage(messageForExcellent);
            }
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
