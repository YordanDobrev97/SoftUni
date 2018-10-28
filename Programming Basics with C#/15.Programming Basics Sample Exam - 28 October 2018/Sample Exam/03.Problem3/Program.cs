using System;
class Program
{
    static void Main()
    {
        string sushi = Console.ReadLine();
        string nameRestaurant = Console.ReadLine();
        int numberOfPortions = int.Parse(Console.ReadLine());
        char order = char.Parse(Console.ReadLine());

        double price = 0;
        //: "sashimi", "maki", "uramaki", "temaki"
        //Sushi Zone", "Sushi Time", "Sushi Bar", "Asian Pub"
        switch (nameRestaurant)
        {
            case "Sushi Zone":
                switch (sushi)
                {
                    case "sashimi":
                        price = 4.99;
                        break;
                    case "maki":
                        price = 5.29;
                        break;
                    case "uramaki":
                        price = 5.99;
                        break;
                    case "temaki":
                        price = 4.29;
                        break;
                }
                break;
            case "Sushi Time":
                switch (sushi)
                {
                    case "sashimi":
                        price = 5.49;
                        break;
                    case "maki":
                        price = 4.69;
                        break;
                    case "uramaki":
                        price = 4.49;
                        break;
                    case "temaki":
                        price = 5.19;
                        break;
                }
                break;
            case "Sushi Bar":
                switch (sushi)
                {
                    case "sashimi":
                        price = 5.25;
                        break;
                    case "maki":
                        price = 5.55;
                        break;
                    case "uramaki":
                        price = 6.25;
                        break;
                    case "temaki":
                        price = 4.75;
                        break;
                }
                break;
            case "Asian Pub":
                switch (sushi)
                {
                    case "sashimi":
                        price = 4.50;
                        break;
                    case "maki":
                        price = 4.80;
                        break;
                    case "uramaki":
                        price = 5.50;
                        break;
                    case "temaki":
                        price = 5.50;
                        break;
                }
                break;
            default:
                Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
                break;
        }
        double cost = numberOfPortions * price;

        if (order == 'Y')
        {
            cost = cost + (cost * 0.20);
        }
        if (price != 0)
        {
            Console.WriteLine($"Total price: {Math.Ceiling(cost)} lv.");
        }
    }
}
