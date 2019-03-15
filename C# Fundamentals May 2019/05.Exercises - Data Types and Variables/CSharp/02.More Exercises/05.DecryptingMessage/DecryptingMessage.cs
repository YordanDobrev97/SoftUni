using System;

namespace _05.DecryptingMessage
{
    public class DecryptingMessage
    {
        public static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numberCharachter = int.Parse(Console.ReadLine());

            string cryptingMessage = string.Empty;
            for (int i = 0; i < numberCharachter; i++)
            {
                char charachter = char.Parse(Console.ReadLine());
                cryptingMessage += (char)(charachter + key);
            }
            Console.WriteLine(cryptingMessage);
        }
    }
}
