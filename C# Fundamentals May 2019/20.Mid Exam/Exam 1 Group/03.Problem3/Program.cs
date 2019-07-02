using System;
using System.Linq;

namespace _03.Problem3
{
    class Program
    {
        static void Main()
        {
            var contacts = Console.ReadLine().Split(" ").ToList();
            string line = Console.ReadLine();

            while (true)
            {
                string[] arguments = line.Split(" ");
                string command = arguments[0];

                switch (command)
                {
                    case "Add":
                        string contact = arguments[1];
                        int index = int.Parse(arguments[2]);

                        if (!contacts.Contains(contact))
                        {
                            contacts.Add(contact);
                        }
                        else
                        {
                            if (index >= 0 && index <= contacts.Count - 1)
                            {
                                contacts.Insert(index, contact);
                                //contacts[index] = contact;
                            }
                        }
                        break;
                    case "Remove":
                        index = int.Parse(arguments[1]);

                        if (index >= 0 && index <= contacts.Count - 1)
                        {
                            contacts.RemoveAt(index);
                        }
                        break;
                    case "Export":
                        int startIndex = int.Parse(arguments[1]);
                        int count = int.Parse(arguments[2]);

                        if (count > contacts.Count)
                        {
                            count = contacts.Count - startIndex;
                        }

                        var rangeConcactss = contacts.GetRange(startIndex, 
                            count); 
                        Console.WriteLine($"{string.Join(" ", rangeConcactss)}");
                        break;
                    case "Print":
                        if (arguments[1] == "Normal")
                        {
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                        }
                        else 
                        {
                            contacts.Reverse();
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                        }
                        return;
                }

                line = Console.ReadLine();
            }
        }
    }
}
