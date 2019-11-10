using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            var radiusIn = this.radius - 0.4;
            var radiusOut = this.radius + 0.4;

            for (int y = this.radius; y >= -this.radius; y--)
            {
                for (double x = -this.radius; x < radiusOut; x+= 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private void FirstPart()
        {
            Console.Write(new string(' ', this.radius));
            Console.WriteLine(new string('*', radius * 2 + 1));
        }
    }
}
