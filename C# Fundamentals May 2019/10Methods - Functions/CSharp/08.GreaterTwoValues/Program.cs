using System;

namespace _08.GreaterTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int maxIntValue = GetIntegerMax(firstValue, secondValue);
                    Console.WriteLine(maxIntValue);
                    break;
                case "char":
                    char maxCharValue = GetCharMax(firstValue, secondValue);
                    Console.WriteLine(maxCharValue);
                    break;
                case "string":
                    string maxStringValue = GetStringMax(firstValue, secondValue);
                    Console.WriteLine(maxStringValue);
                    break;
                default:
                    break;
            }
        }

        private static string GetStringMax(string firstValue, string secondValue)
        {
            int max = firstValue.CompareTo(secondValue);
            if (max > 0)
            {
                return firstValue;
            }
            return secondValue; 
        }

        private static char GetCharMax(string firstValue, string secondValue)
        {
            int first = char.Parse(firstValue);
            int second = char.Parse(secondValue);
            int max = Math.Max(first, second);
            return (char)max;
        }

        private static int GetIntegerMax(string firstValue, string secondValue)
        {
            int max = Math.Max(int.Parse(firstValue), int.Parse(secondValue));
            return max;
        }
    }
}
