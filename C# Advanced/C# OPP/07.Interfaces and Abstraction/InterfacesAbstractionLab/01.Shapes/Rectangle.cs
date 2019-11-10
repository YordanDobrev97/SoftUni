using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            FrontPart();
            MiddlePart();
            FrontPart();
        }

        private void MiddlePart()
        {
            for (int row = 0; row < this.height - 2; row++)
            {
                Console.Write("*");
                for (int col = 0; col < this.width - 2; col++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }

        private void FrontPart()
        {
            Console.WriteLine(new string('*', this.width));
        }
    }
}
