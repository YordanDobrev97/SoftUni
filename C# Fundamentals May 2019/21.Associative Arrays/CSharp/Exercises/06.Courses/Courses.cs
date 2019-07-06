using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Courses
    {
        static void Main()
        {
            string line = Console.ReadLine();
            var courses = new Dictionary<string, List<string>>();

            while (line != "end")
            {
                string[] elements = line.Split(" : ");
                string nameCourse = elements[0];
                string username = elements[1];

                if (!courses.ContainsKey(nameCourse))
                {
                    courses.Add(nameCourse, new List<string>());
                }

                courses[nameCourse].Add(username);

                line = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var user in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
