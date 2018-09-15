using System;
using System.Text;

namespace _09.Secret_Message
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();
            

            for (int i = message.Length - 1; i >= 0; i--)
            {
                char character = message[i];
                if (!char.IsDigit(character))
                {
                    stringBuilder.Append(character);
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
