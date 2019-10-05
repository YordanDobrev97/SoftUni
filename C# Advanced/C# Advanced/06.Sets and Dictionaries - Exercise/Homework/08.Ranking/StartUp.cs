using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    public class  Course
    {
        public Course(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }

        public int Points{ get; set; }
    }

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> coursePassword = new Dictionary<string, string>();

            while (true)
            {
                string contest = Console.ReadLine();

                if (contest == "end of contests")
                {
                    break;
                }

                string[] elements = contest.Split(":");
                string nameContest = elements[0];
                string passwordContest = elements[1];

                if (!coursePassword.ContainsKey(nameContest))
                {
                    coursePassword.Add(nameContest, passwordContest);
                }
            }

            var studentCourses = new Dictionary<string, List<Course>>();
            while (true)
            {
                string submission = Console.ReadLine();

                if (submission == "end of submissions")
                {
                    break;
                }

                string[] elements = submission.Split("=>");
                string course = elements[0];
                string password = elements[1];
                string user = elements[2];
                int points = int.Parse(elements[3]);

                if (coursePassword.ContainsKey(course) && 
                    coursePassword.ContainsValue(password))
                {
                    if (!studentCourses.ContainsKey(user))
                    {
                        studentCourses.Add(user, new List<Course>());
                    }
                    
                    if (!studentCourses[user].Any(x => x.Name == course))
                    {
                        studentCourses[user].Add(new Course(course, points));
                    }
                    else
                    {
                        var currentCourse =(Course)(studentCourses[user].FirstOrDefault(x => x.Name == course));

                        if (currentCourse.Points < points)
                        {
                            currentCourse.Points = points;
                        }

                    }
                }
            }

            string bestCandidateName = string.Empty;
            int bestCandidatePoints = 0;

            foreach (var item in studentCourses)
            {
                int currentPoints = 0;
                foreach (var point in item.Value)
                {
                    currentPoints += point.Points;
                }

                if (currentPoints > bestCandidatePoints)
                {
                    bestCandidateName = item.Key;
                    bestCandidatePoints = currentPoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in studentCourses.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var course in item.Value.OrderByDescending(x => x.Points))
                {
                    Console.WriteLine($"#  {course.Name} -> {course.Points}");
                }
            }
        }
    }
}
