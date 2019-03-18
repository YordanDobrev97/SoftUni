using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
    }

    public static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < numberOfStudents; i++)
        {
            string[] studentParams = Console.ReadLine()
                .Split(" ");
            string firstName = studentParams[0];
            string lastName = studentParams[1];
            double grade = double.Parse(studentParams[2]);

            Student student = new Student(firstName, lastName, grade);
            students.Add(student);
        }

        students = students.OrderByDescending(x => x.Grade).ToList();

        foreach (var student in students)
        {
            Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
        }
    }
}
