using System;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main()
        {
            //-123 345 982| 34 -332
            var input = Console.ReadLine();

            int last = input.Length - 1;

            List<int> resultList = new List<int>();

            List<int> currentNumbers = new List<int>();

            while (true)
            {
                int result;
                bool hasNumber = int.TryParse(input[last].ToString(), out result);

                bool isOutOfRange = false;
                if (hasNumber)
                {
                    string numberAsString = string.Empty;
                    while (input[last] != ' ' && input[last] != '|')
                    {
                        int value = input[last] - '0';

                        if (input[last] != '-')
                        {
                            numberAsString = numberAsString.Insert(0, value.ToString());
                        }
                        else if (input[last] == '-')
                        {
                            numberAsString = numberAsString.Insert(0, "-");
                        }


                        last--;

                        if (last < 0)
                        {
                            isOutOfRange = true;
                            break;
                        }
                    }

                    result = int.Parse(numberAsString);

                    currentNumbers.Add(result);
                }

                if (isOutOfRange)
                {
                    break;
                }

                if (input[last].ToString().Trim() == "|")
                {
                    currentNumbers.Reverse();
                    resultList.AddRange(currentNumbers);
                    currentNumbers.Clear();
                }

                last--;

                if (last < 0)
                {
                    break;
                }
            }

            currentNumbers.Reverse();
            resultList.AddRange(currentNumbers);

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
