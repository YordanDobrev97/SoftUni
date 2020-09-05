using System;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (InvalidInputValue(value))
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (InvalidInputValue(value))
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (InvalidInputValue(value))
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double CalculateVolume()
        {
            var volume = this.length * this.width * this.height;
            return volume;
        }

        public double CalculateSurfaceArea()
        {
            var area = 2 * length * width + 2 * length * height + 2 * width * height;
            return area;
        }

        public double CalculateLateralSurfaceArea()
        {
            var area = 2 * length * height + 2 * width * height;
            return area;
        }

        private static bool InvalidInputValue(double value)
        {
            return value <= 0;
        }
    }
}
