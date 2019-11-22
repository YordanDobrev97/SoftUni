using System;
using System.Collections.Generic;

namespace _06.ValidPerson
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Person person1 = new Person("Pesho", "Ivanov", 10);
                //Person person2 = new Person(null, "Ivanov", 10);
                //Person person3 = new Person("Pesho", null, 10);
                Person person4 = new Person("Pesho", "Ivanov", -10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
