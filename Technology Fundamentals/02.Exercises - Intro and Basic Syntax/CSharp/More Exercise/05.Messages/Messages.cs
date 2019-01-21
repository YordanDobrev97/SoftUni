using System;
using System.Text;

namespace _05.Messages
{
    public class Messages
    {
        public static void Main()
        {
            int numberInputRows = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberInputRows; i++)
            {
                string currentNumber = Console.ReadLine();
                int firstSymbol = 0;

                if (currentNumber.Length > 0)
                {
                    firstSymbol = currentNumber[0] - '0';
                }

                int result = (firstSymbol - 2) * 3 + (currentNumber.Length - 1);

                if (firstSymbol == 8 || firstSymbol == 9)
                {
                    result += 1;
                }

                if (firstSymbol == 0)
                {
                    sb.Append(' ');
                }
                else
                {
                    sb.Append((char)(result + 'a'));
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
