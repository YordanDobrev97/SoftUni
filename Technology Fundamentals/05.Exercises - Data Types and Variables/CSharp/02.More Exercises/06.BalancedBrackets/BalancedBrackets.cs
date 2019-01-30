using System;

namespace _06.BalancedBrackets
{
    public class BalancedBrackets
    {
        public static void Main()
        {
            int numberLines = int.Parse(Console.ReadLine());
            
            bool isBalanced = true;

            int counter = 1;
            while (counter < numberLines)
            {
                string line = Console.ReadLine();

                if (line == "(")
                {
                    string expression = Console.ReadLine();
                    string closedBracket = Console.ReadLine();

                    if (closedBracket == ")" && ContainsNumber(expression))
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                    counter += 2;
                }
                else
                {
                    if (line == ")")
                    {
                        isBalanced = false;
                        break;
                    }
                }
                counter++;
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }

        private static bool ContainsNumber(string expression)
        {
            string[] items = expression.Split(' ');
            int value;
            if(int.TryParse(items[0], out value))
            {
                return true;
            }
            return false;
        }
    }
}
