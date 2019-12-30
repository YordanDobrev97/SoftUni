using System;
using System.Linq;

namespace _01.Username
{
    public class StartUp
    {
        public static void Main()
        {
            string username = Console.ReadLine();

            while (true)
            {
                string[] elements = Console.ReadLine().Split();
                string command = elements[0];

                if (command == "Sign" && elements[1] == "up")
                {
                    break;
                }

                if (command == "Case")
                {
                    if (elements[1] == "lower")
                    {
                        username = username.ToLower();
                    }
                    else
                    {
                        username = username.ToUpper();
                    }

                    Console.WriteLine(username);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(elements[1]);
                    int endIndex = int.Parse(elements[2]);

                    if (startIndex >= 0 && endIndex < username.Length)
                    {
                        string partText = GetSubstring(username, startIndex, endIndex);
                        char[] array = partText.ToCharArray();
                        Array.Reverse(array);
                        Console.WriteLine(new string(array));
                    }
                }
                else  if (command == "Cut")
                {
                    if (!username.Contains(elements[1]))
                    {
                        Console.WriteLine($"The word {username} doesn't contain {elements[1]}.");
                    }
                    else
                    {
                        int startIndex = username.IndexOf(elements[1]);
                        username = username.Remove(startIndex, elements[1].Length);
                        Console.WriteLine(username);
                    }
                }
                else if (command == "Replace")
                {
                    string symbol = elements[1];
                    username = username.Replace(symbol, "*");
                    Console.WriteLine(username);

                }
                else if (command == "Check")
                {
                    char symbol = elements[1][0];

                    if (username.Contains(symbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                }
            }
        }

        public static string GetSubstring(string username, int startIndex, int endIndex)
        {
           return username.Substring(startIndex, endIndex - startIndex + 1);
        }
    }
}
