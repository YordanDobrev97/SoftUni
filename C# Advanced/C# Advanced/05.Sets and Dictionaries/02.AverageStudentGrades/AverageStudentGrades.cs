using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());

            var studentWithGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] student = Console.ReadLine().Split();
                string name = student[0];
                double grade = double.Parse(student[1]);

                if (!studentWithGrades.ContainsKey(name))
                {
                    studentWithGrades.Add(name, new List<double>());
                }

                studentWithGrades[name].Add(grade);
            }

            foreach (var item in studentWithGrades)
            {
                var name = item.Key;
                var grades = item.Value.Select(x => double.Parse($"{x.ToString("F2")}")).ToArray();
                var average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
