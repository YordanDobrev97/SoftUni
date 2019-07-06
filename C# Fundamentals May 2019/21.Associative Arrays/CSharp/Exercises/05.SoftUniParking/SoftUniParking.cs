using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class SoftUniParking
    {
        static void Main()
        {
            int countRegisterUser = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, string>();

            for (int i = 0; i < countRegisterUser; i++)
            {
                string[] userData = Console.ReadLine().Split(" ");
                string command = userData[0];
                string username = userData[1];
                switch (command)
                {
                    case "register":
                        string licensePlateNumber = userData[2];

                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else if (users.ContainsValue(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
