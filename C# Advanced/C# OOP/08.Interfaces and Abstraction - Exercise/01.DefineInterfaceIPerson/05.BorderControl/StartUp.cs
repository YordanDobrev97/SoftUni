using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        private const int LengthCreateCitizen = 3;

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
                    string name = elements[0];
                    string age = elements[1];
                    string id = elements[2];

                    result = factory.Create(TypeIdentificator.Citizen, name, age, id);
                }
                else
                {
                    string model = elements[0];
                    string idRobot = elements[1];
                    result = factory.Create(TypeIdentificator.Robot, model, idRobot);
                }

                list.Add(result);
            }

            string idInput = Console.ReadLine();

            var ids = list.Where(x => x.Id.EndsWith(idInput)).ToArray();

            foreach (var item in ids)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
