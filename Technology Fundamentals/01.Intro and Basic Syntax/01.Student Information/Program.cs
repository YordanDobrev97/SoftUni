using System;

namespace _01.Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentAverageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentAverageGrade:f2}");
        }
    }
}
