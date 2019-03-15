using System;

namespace _01.DataTypeFinder
{
    public class DataTypeFinder
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string dataType = command;

                string correctlyDataType = ReturnCorrectlyDataType(dataType);

                Console.WriteLine(correctlyDataType);

                command = Console.ReadLine();
            }
        }

        private static string ReturnCorrectlyDataType(string dataType)
        {
            string output = string.Empty;
            int value;
            double valueDouble;
            char valueChar;
            bool valueBool;
            if(int.TryParse(dataType, out value))
            {
                output = $"{value} is integer type";
            }
            else if(double.TryParse(dataType, out valueDouble))
            {
                output = $"{dataType} is floating point type";
            }
            else if(char.TryParse(dataType, out valueChar))
            {
                output = $"{valueChar} is character type";
            }
            else if(bool.TryParse(dataType, out valueBool))
            {
                output = $"{dataType} is boolean type";
            }
            else
            {
                output = $"{dataType} is string type";
            }

            return output;
        }
    }
}
