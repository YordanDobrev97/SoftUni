using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string command = Console.ReadLine();

        List<Student> students = new List<Student>();

        while (command != "end")
        {
            string[] paramsCommand = command.Split(' ');
            string firstName = paramsCommand[0];
            string secondName = paramsCommand[1];
            int age = int.Parse(paramsCommand[2]);
            string homeTown = paramsCommand[3];

            Student currentStudent = new Student(firstName, secondName, age, homeTown);

            if (students.Exists(s => s.FirstName == firstName
                 && s.SecondName == secondName))
            {
                var student = students.FirstOrDefault(x => x.FirstName == firstName && x.SecondName == secondName);
                int indexOfStudent = students.IndexOf(student);
                students.RemoveAt(indexOfStudent);
                Student newStudent = new Student(firstName, secondName, age, homeTown);
                students.Insert(indexOfStudent, newStudent);

            }
            else
            {
                students.Add(currentStudent);
            }

            command = Console.ReadLine();
        }

        string city = Console.ReadLine();

        List<Student> filterStudnets = students.Where(s => s.HomeTown == city).ToList();

        foreach (var student in filterStudnets)
        {
            Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
        }
    }
}