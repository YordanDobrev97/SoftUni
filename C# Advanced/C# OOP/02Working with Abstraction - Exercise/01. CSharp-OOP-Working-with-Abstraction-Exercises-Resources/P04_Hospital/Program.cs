using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            var doctors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departament = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];
                var fullName = firstName + secondName;

                if (!doctors.ContainsKey(firstName + secondName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int stai = 0; stai < 20; stai++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool hasPlace = departments[departament].SelectMany(x => x).Count() < 60;
                if (hasPlace)
                {
                    int staq = 0;
                    doctors[fullName].Add(patient);
                    for (int st = 0; st < departments[departament].Count; st++)
                    {
                        if (departments[departament][st].Count < 3)
                        {
                            staq = st;
                            break;
                        }
                    }
                    departments[departament][staq].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split();

                if (elements.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[elements[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (elements.Length == 2 && int.TryParse(elements[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[elements[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[elements[0] + elements[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
