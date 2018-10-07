using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Box box = new Box();

            box.setLength(6.0);
            box.setBreadth(7.0);
            box.setHeight(5.0);

            double volume = box.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);
        }
    }
    class Box
    {
        private double length;
        private double breadth; 
        private double height;
        
        public void setLength(double length)
        {
            this.length = length;
        }
        public void setBreadth(double breadth)
        {
            this.breadth = breadth;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }
}
