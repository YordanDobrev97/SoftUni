using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Chat
{
    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            List<string> chatMessage = new List<string>();
            while (line != "end")
            {
                string[] inputParams = line.Split();

                switch (inputParams[0])
                {
                    case "Chat":
                        chatMessage.Add(inputParams[1]);
                        break;
                    case "Delete":
                        if (chatMessage.Contains(inputParams[1]))
                        {
                            chatMessage.Remove(inputParams[1]);
                        }
                        break;
                    case "Edit":
                        int indexMessageEdit = chatMessage.IndexOf(inputParams[1]);
                        if (indexMessageEdit != -1)
                        {
                            chatMessage[indexMessageEdit] = inputParams[2];
                        }
                        break;
                    case "Pin":
                        int indexMessage = chatMessage.IndexOf(inputParams[1]);
                        if (indexMessage != -1)
                        {
                            string message = chatMessage[indexMessage];
                            chatMessage.RemoveAt(indexMessage);
                            chatMessage.Add(message);
                        }
                        break;
                    case "Spam":
                        var messages = inputParams.Skip(1).Take(inputParams.Length - 1).ToList();
                        chatMessage.AddRange(messages);
                        break;
                }

                line = Console.ReadLine();
            }

            foreach (var message in chatMessage)
            {
                Console.WriteLine(message);
            }
        }
    }
}
