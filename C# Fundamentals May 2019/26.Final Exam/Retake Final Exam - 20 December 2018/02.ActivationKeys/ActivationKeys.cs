using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VaporWinterSale
{
    class Program
    {
        static bool IsValid(string item)
        {
            foreach (var symbol in item)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            string line = Console.ReadLine();

            string[] elements = line.Split("&");

            List<string> validKeys = new List<string>();

            foreach (var item in elements)
            {
                if (IsValid(item))
                {
                    validKeys.Add(item);
                }
            }

            List<string> keys = new List<string>();

            foreach (var key in validKeys)
            {
                StringBuilder result = new StringBuilder();
                int count = 0;
                int currentCount = 1;
                for (int i = 0; i < key.Length; i++)
                {
                    string value = key[i].ToString().ToUpper();
                    if (char.IsDigit(key[i]))
                    {
                        int newValue = 9 - (key[i] - '0');
                        value = newValue.ToString();
                    }
                    else
                    {
                        if (key.Length == 16)
                        {
                            count = 4;
                        }
                        else if (key.Length == 25)
                        {
                            count = 5;
                        }
                    }

                    if (currentCount == count)
                    {
                        result.Append(value);
                        result.Append("-");
                        currentCount = 0;
                    }
                    else
                    {
                        result.Append(value);
                    }
                    currentCount++;
                }
                result = result.Remove(result.Length - 1, 1);

                keys.Add(result.ToString());
            }

            Console.WriteLine(string.Join(", ", keys));
        }
    }
}
