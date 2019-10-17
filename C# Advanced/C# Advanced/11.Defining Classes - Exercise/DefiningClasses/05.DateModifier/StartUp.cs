using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDateInput = Console.ReadLine();
            string seoncdDateInput = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            double different = dateModifier.DifferentBetweenDays(firstDateInput, seoncdDateInput);
            Console.WriteLine(different);
        }
    }
}
