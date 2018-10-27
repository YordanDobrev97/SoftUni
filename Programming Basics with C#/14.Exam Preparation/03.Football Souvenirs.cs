using System;
class Program
{
    static void Main()
    {
        string country = Console.ReadLine();
        string souvenir = Console.ReadLine();
        int buySouvenir = int.Parse(Console.ReadLine());

        double price = 0;
        bool isValid = true;
        if (country == "Argentina")
        {
            switch (souvenir)
            {
                case "flags":
                    price = 3.25;
                    break;
                case "caps":
                    price = 7.20;
                    break;
                case "posters":
                    price = 5.10;
                    break;
                case "stickers":
                    price = 1.25;
                    break;
                default:
                    Console.WriteLine("Invalid stock!");
                    isValid = false;
                    break;
            }
        }
        else if (country == "Brazil")
        {
            switch (souvenir)
            {
                case "flags":
                    price = 4.20;
                    break;
                case "caps":
                    price = 8.50;
                    break;
                case "posters":
                    price = 5.35;
                    break;
                case "stickers":
                    price = 1.20;
                    break;
                default:
                    Console.WriteLine("Invalid stock!");
                    isValid = false;
                    break;
            }
        }
        else if (country == "Croatia")
        {
            switch (souvenir)
            {
                case "flags":
                    price = 2.75;
                    break;
                case "caps":
                    price = 6.90;
                    break;
                case "posters":
                    price = 4.95;
                    break;
                case "stickers":
                    price = 1.10;
                    break;
                default:
                    Console.WriteLine("Invalid stock!");
                    isValid = false;
                    break;
            }
        }
        else if(country == "Denmark")
        {
            switch (souvenir)
            {
                case "flags":
                    price = 3.10;
                    break;
                case "caps":
                    price = 6.50;
                    break;
                case "posters":
                    price = 4.80;
                    break;
                case "stickers":
                    price = 0.90;
                    break;
                default:
                    Console.WriteLine("Invalid stock!");
                    isValid = false;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid country!");
            isValid = false;
        }

        if (isValid)
        {
            Console.WriteLine($"Pepi bought {buySouvenir} {souvenir} of {country} for {price * buySouvenir:f2} lv.");
        }
    }
}
