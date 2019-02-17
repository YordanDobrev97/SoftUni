using System;

namespace _01.DataTypes
{
    public class DataTypes
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();

            if (IsDataTypeInt(dataType))
            {
                int parseValue = int.Parse(value);
                Console.WriteLine(parseValue * 2);
            }
            else if (IsDataTypeDouble(dataType))
            {
                double parseValue = double.Parse(value);
                Console.WriteLine($"{parseValue * 1.5:f2}");
            }
            else
            {
                Console.WriteLine($"${value}$");
            }
        }

        private static bool IsDataTypeDouble(string dataType)
        {
            return dataType == "real" ? true : false;
        }

        private static bool IsDataTypeInt(string dataType)
        {
            return dataType == "int" ? true : false;
        }
    }
}
