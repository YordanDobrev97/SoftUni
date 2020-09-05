using System;

namespace ClassBox
{
    public class StartUp
    {
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width =  double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                double volume = box.CalculateVolume();
                double surfaceArea = box.CalculateSurfaceArea();
                double lateralSurfaceArea = box.CalculateLateralSurfaceArea();

                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
