using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            int remainder = 0;
            int length = line.Length;

            for (int i = 0; i < length; i++)
            {
                bool hasNumber = HasNumber(line[i]);

                bool isEnd = false;
                if (hasNumber)
                {
                    int power = line[i] - '0';
                    power += remainder;

                    int count = 0;
                    while (line[i] != '>' && count < power)
                    {
                        line = line.Remove(i, 1);
                        count++;

                        if (i > line.Length - 1)
                        {
                            isEnd = true;
                            break;
                        }
                    }

                    if (count < power)
                    {
                        remainder += power - count;
                        i--;
                    }
                }

                length = line.Length;

                if (isEnd)
                {
                    break;
                }
            }

            Console.WriteLine(line);
        }

        private static bool HasNumber(char input)
        {
            return int.TryParse(input.ToString(), out int value);
        }
    }
}
