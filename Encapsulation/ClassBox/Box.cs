using System;
using System.Collections.Generic;
using System.Text;

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

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public void Volume()
        {
            double result = this.Height * this.Width * this.Length;

            Console.WriteLine($"Volume - {result:f2}");
        }

        public void LateralSurfaceArea()
        {
            double result = 2 * this.Length * this.height + 2 * this.width * this.height;

            Console.WriteLine($"Lateral Surface Area - {result:f2}");
        }

        public void SurfaceArea()
        {
            double result = 2 * this.length * this.width + 2 * this.Length * this.height + 2 * this.width * this.height;

            Console.WriteLine($"Surface Area - {result:f2}");
        }
    }
}
