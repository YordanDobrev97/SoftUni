using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string command = Console.ReadLine();

        List<Box> boxes = new List<Box>();
        while (command != "end")
        {
            string[] commandParams = command.Split(' ');
            string serialNumber = commandParams[0];
            string itemName = commandParams[1];
            int itemQuantity = int.Parse(commandParams[2]);
            double itemPrice = double.Parse(commandParams[3]);
            double priceBox = itemQuantity * itemPrice;

            Item currentItem = new Item(itemName, itemPrice);
            Box currentBox = new Box(serialNumber, currentItem, itemQuantity, priceBox);

            boxes.Add(currentBox);
            command = Console.ReadLine();
        }

        boxes = boxes.OrderByDescending(x => x.ItemPrice).ToList();

        foreach (var box in boxes)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.ItemPrice:f2}");
        }
    }
}

