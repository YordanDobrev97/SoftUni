using System;

namespace _09.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            int numberOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOperations; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ');

                string command = elements[0];

                switch (command)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }
        }
    }
}
