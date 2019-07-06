using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var studentPoints = new Dictionary<string, int>();
            var studentsSubmissions = new Dictionary<string, int>();
            while (line != "exam finished")
            {
                var elements = line.Split("-");

                var name = elements[0];
                if (elements.Length == 3)
                {
                    var language = elements[1];
                    var points = int.Parse(elements[2]);

                    if (!studentPoints.ContainsKey(name))
                    {
                        studentPoints.Add(name, points);
                    }
                    else
                    {
                        if (studentPoints[name] < points)
                        {
                            studentPoints[name] = points;
                        }
                    }

                    if (!studentsSubmissions.ContainsKey(language))
                    {
                        studentsSubmissions.Add(language, 0);
                    }
                    studentsSubmissions[language]++;
                }
                else if (elements.Length == 2) 
                {
                    //has banned user
                    studentPoints.Remove(name);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Results:");
            foreach (var item in studentPoints.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine($"Submissions:");
            foreach (var item in studentsSubmissions.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
