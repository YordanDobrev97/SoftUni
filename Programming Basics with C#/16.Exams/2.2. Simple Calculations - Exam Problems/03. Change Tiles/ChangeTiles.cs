using System;

namespace _03.Change_Tiles
{
    class ChangeTiles
    {
        static void Main()
        {
            int lengthOfSide = int.Parse(Console.ReadLine());
            double widthPerTiles = double.Parse(Console.ReadLine());
            double lengthPerTiles = double.Parse(Console.ReadLine());
            int widthPerBench = int.Parse(Console.ReadLine());
            int lengthPerBench = int.Parse(Console.ReadLine());

            double totalArea = lengthOfSide * lengthOfSide;
            double areaBench = (double)widthPerBench * lengthPerBench;
            double areaPerCover = totalArea - areaBench;
            double areaPerTiles = widthPerTiles * lengthPerTiles;
            double needTiles = areaPerCover / lengthOfSide;
            double needTime = needTiles * 0.2;

            Console.WriteLine(needTiles);
            Console.WriteLine(needTime);
        }
    }
}
