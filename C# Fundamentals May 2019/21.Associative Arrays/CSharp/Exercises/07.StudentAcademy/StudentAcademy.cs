using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class StudentAcademy
    {
        static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < countStudents; i++)
            {
                string nameStudent = Console.ReadLine();
                double gradeStudent = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(nameStudent))
                {
                    students.Add(nameStudent, new List<double>());
                }
                students[nameStudent].Add(gradeStudent);
            }

            var filterStudents = students.Where(x => x.Value.Average() >= 4.50)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var item in filterStudents.OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
