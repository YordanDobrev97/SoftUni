using System;

namespace FoodShortage
{
    public class IdentificatorFactory
    {
        public IIdentifiable Create(TypeIdentificator identifiable,  params string[] items)
        {
            switch (identifiable)
            {
                case TypeIdentificator.Citizen:
                    string[] birthdayArguments = items[3].Split("/");
                    int day = int.Parse(birthdayArguments[0]);
                    int month = int.Parse(birthdayArguments[1]);
                    int year = int.Parse(birthdayArguments[2]);
                    return new Citizen(items[0], int.Parse(items[1]), items[2], new DateTime(year, month, day));
                case TypeIdentificator.Robot:
                    return new Robot(items[0], items[1]);
                case TypeIdentificator.Pet:
                    string[] birthdayArgs = items[1].Split("/");
                    day = int.Parse(birthdayArgs[0]);
                    month = int.Parse(birthdayArgs[1]);
                    year = int.Parse(birthdayArgs[2]);
                    return new Pet(items[0], new DateTime(year, month, day));
                default:
                    throw new ArgumentException("Invalid creation");
            }
        }
    }
}
