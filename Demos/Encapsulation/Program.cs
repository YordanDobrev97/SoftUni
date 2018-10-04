using System;

namespace Encapsulation
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ReadAreaRectagle();

            int area = rectangle.GetArea();
            Console.WriteLine("Rectagle area: {0}", area);
        }
    }
}
