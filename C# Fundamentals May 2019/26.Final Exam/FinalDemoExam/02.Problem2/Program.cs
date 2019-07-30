using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Problem2
{
    class Program
    {
        static void Main()
        {
            string[] emoji = Console.ReadLine()
                .Split(" ")
                .Where(x => x.Contains(":"))
                .ToArray();

            List<string> validEmojis = new List<string>();

            foreach (var item in emoji)
            {
                if (HasValidEmoji(item))
                {
                    validEmojis.Add(item);
                }
            }
        }

        private static bool HasValidEmoji(string item)
        {
            bool startWithColon = IsStartWithColon(item);
            bool anyFourCharacters = HasFourAnyCharacters(item);
            bool endWithPossiblePunctuations = HasPossiblePunctuation(item);

            if (startWithColon && anyFourCharacters && endWithPossiblePunctuations)
            {
                return true;
            }

            return false;
        }

        private static bool HasPossiblePunctuation(string item)
        {
            throw new NotImplementedException();
        }

        private static bool HasFourAnyCharacters(string item)
        {
            //:sunny:
            if (!IsStartWithColon(item) && item[item.Length - 1] != ':')
            {
                return false;
            }

            item = item.Remove(0);

            if (item[item.Length - 1] != ':')
            {
                item.Remove(item.Length - 1);
            }

        }

        private static bool IsStartWithColon(string item)
        {
            return item.StartsWith(":");
        }
    }
}
