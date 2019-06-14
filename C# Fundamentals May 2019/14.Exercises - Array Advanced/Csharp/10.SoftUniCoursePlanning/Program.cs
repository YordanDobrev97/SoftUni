using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main()
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string line = Console.ReadLine();

            while (line != "course start")
            {
                string[] arguments = line.Split(":");

                switch (arguments[0])
                {
                    case "Add":
                        string titleLesson = arguments[1];
                        if (!lessons.Contains(titleLesson))
                        {
                            lessons.Add(titleLesson);
                        }
                        break;
                    case "Insert":
                        titleLesson = arguments[1];
                        int index = int.Parse(arguments[2]);

                        if (!lessons.Contains(titleLesson))
                        {
                            lessons.Insert(index, titleLesson);
                        }
                        break;
                    case "Remove":
                        titleLesson = arguments[1];

                        if (lessons.Contains(titleLesson))
                        {
                            lessons.Remove(titleLesson);

                            if (lessons.Contains($"{titleLesson}-Exercise"))
                            {
                                lessons.Remove($"{titleLesson}-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                        string firstLesson = arguments[1];
                        string secondLesson = arguments[2];

                        bool hasFirstLessonExercise = lessons.Contains($"{firstLesson}-Exercise");
                        bool hasSecondLessonExercise = lessons.Contains($"{secondLesson}-Exercise");
                        
                        if (hasFirstLessonExercise)
                        {
                            lessons.Add(firstLesson);
                        }
                        else if (hasSecondLessonExercise)
                        {
                            lessons.Add(secondLesson);
                        }

                        if (lessons.Contains(firstLesson) && lessons.Contains(secondLesson))
                        {
                            int indexFirstLesson = lessons.IndexOf(firstLesson);
                            int indexSecondLesson = lessons.IndexOf(secondLesson);

                            string temp = lessons[indexFirstLesson];
                            lessons[indexFirstLesson] = lessons[indexSecondLesson];
                            lessons[indexSecondLesson] = temp;

                            if (hasSecondLessonExercise)
                            {
                                int indexExerises = lessons.IndexOf($"{secondLesson}-Exercise");
                                string lessonExerises = lessons[indexExerises];
                                int indexOfLesson = lessons.IndexOf(secondLesson);

                                lessons.Remove(lessonExerises);
                                lessons.Insert(indexOfLesson + 1, lessonExerises);   
                            }
                            else if (hasFirstLessonExercise)
                            {
                                int indexExerises = lessons.IndexOf($"{firstLesson}-Exercise");
                                string lessonExerises = lessons[indexExerises];
                                int indexOfLesson = lessons.IndexOf(firstLesson);

                                lessons.Remove(lessonExerises);
                                lessons.Insert(indexOfLesson + 1, lessonExerises);
                            }
                        }
                        break;
                    case "Exercise":
                        titleLesson = arguments[1];
                        string item = $"{titleLesson}-Exercise";
                        if (lessons.Contains(titleLesson))
                        {
                            int indexOfLesson = lessons.IndexOf(titleLesson);
                            lessons.Insert(indexOfLesson + 1, item);
                        }
                        else
                        {
                            lessons.Add(titleLesson);
                            lessons.Add(item);
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            int count = 1;
            foreach (var lesson in lessons)
            {
                Console.WriteLine($"{count}.{lesson}");
                count++;
            }
        }
    }
}
