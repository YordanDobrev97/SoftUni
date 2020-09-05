using System;

namespace _07.CustomException
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Student student = new Student("Pesho", null);

            }
            catch (InvalidPersonNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
