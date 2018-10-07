using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main()
        {
            int? num = null;

            int? num2 = 45;

            double? num3 = new double?();

            Console.WriteLine("Values: {0} {1} {2}" , num,num2,num3);
        }
    }
}
