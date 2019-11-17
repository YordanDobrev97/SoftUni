using System;

namespace FoodShortage
{
    public class BuyerFactory
    {
        public IBuyer Create(TypeBuyer type, params string[] items)
        {
            switch (type)
            {
                case TypeBuyer.Rebel:
                    return new Rebel(items[0], int.Parse(items[1]), items[2]);
                case TypeBuyer.Citizen:
                    string[] birthdayArguments = items[3].Split("/");
                    int day = int.Parse(birthdayArguments[0]);
                    int month = int.Parse(birthdayArguments[1]);
                    int year = int.Parse(birthdayArguments[2]);
                    return new Citizen(items[0], int.Parse(items[1]), items[2], new DateTime(year, month, day));
                default:
                    throw new ArgumentException("Invalid creation!");
            }
        }
    }
}
