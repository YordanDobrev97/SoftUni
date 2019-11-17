using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        private const int LengthCreateCitizen = 5;

        public static void Main()
        {
            List<IIdentifiable> list = new List<IIdentifiable>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] elements = line.Split();
                int length = elements.Length;

                IdentificatorFactory factory = new IdentificatorFactory();
                IIdentifiable result = null;

                if (length == LengthCreateCitizen)
                {
                    string name = elements[1];
                    string age = elements[2];
                    string id = elements[3];
                    string birthday = elements[4];

                    result = factory.Create(TypeIdentificator.Citizen, name, age, id, birthday);
                }
                else if (elements[0] == "Robot")
                {
                    string model = elements[1];
                    string idRobot = elements[2];
                    result = factory.Create(TypeIdentificator.Robot, model, idRobot);
                }
                else
                {
                    string name = elements[1];
                    string birthday = elements[2];

                    result = factory.Create(TypeIdentificator.Pet, name, birthday);
                }

                list.Add(result);
            }

            int year = int.Parse(Console.ReadLine());

            foreach (var item in list)
            {
                if (item.Birthday.Year == year)
                {
                    Console.WriteLine(item.Birthday.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}
