using System;

namespace Encapsulation
{
    class Rectangle
    {
        private int length;
        private int width;

        public int GetArea()
        {
            return this.length * this.width;
        }
        public void ReadAreaRectagle()
        {
            this.length = int.Parse(Console.ReadLine());
            this.width = int.Parse(Console.ReadLine());

        }
    }
}
