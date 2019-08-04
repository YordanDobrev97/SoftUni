using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem3
{
    class User
    {
        public int Sent { get; set; }

        public int Received { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            var manager = new Dictionary<string, User>();

            while (line != "Statistics")
            {
                string[] elements = line.Split("=");
                string command = elements[0];

                if (command == "Add")
                {
                    string username = elements[1];
                    int sentCountMessage = int.Parse(elements[2]);
                    int reciviedCountMessage = int.Parse(elements[3]);

                    if (!manager.ContainsKey(username))
                    {
                        manager.Add(username, new User());
                        manager[username].Sent = sentCountMessage;
                        manager[username].Received = reciviedCountMessage;
                    }
                }
                else if (command == "Message")
                {
                    string senderUser = elements[1];
                    string receiverUser = elements[2];

                    if (manager.ContainsKey(senderUser)
                        && manager.ContainsKey(receiverUser))
                    {
                        var senderDict = manager[senderUser];
                        var keySender = senderDict.Sent;

                        if (keySender + 1 > capacity 
                            || senderDict.Received + 1 > capacity
                            || keySender + 1 + senderDict.Received + 1 > capacity)
                        {
                            manager.Remove(senderUser);
                            Console.WriteLine($"{senderUser} reached the capacity!");
                        }
                        else
                        {
                            senderDict.Sent++;
                        }

                        var receiverDict = manager[receiverUser];
                        var keyReceiver = receiverDict.Received;

                        if (keyReceiver + 1 > capacity 
                            || receiverDict.Sent + 1 > capacity
                            || keyReceiver + 1 + receiverDict.Sent + 1 > capacity)
                        {
                            manager.Remove(receiverUser);
                            Console.WriteLine($"{receiverUser} reached the capacity!");
                        }
                        else
                        {
                            receiverDict.Received++;
                        }
                    }
                }
                else if (command == "Empty")
                {
                    if (elements[1] == "All")
                    {
                        manager.Clear();
                    }
                    else
                    {
                        while (manager.ContainsKey(elements[1]))
                        {
                            manager.Remove(elements[1]);
                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {manager.Count}");

            foreach (var item in manager.OrderByDescending(x => x.Value.Received)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sent + item.Value.Received}");
            }
        }
    }
}
