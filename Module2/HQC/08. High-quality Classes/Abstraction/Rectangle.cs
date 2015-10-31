namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width = 0;
        private double height = 0;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Rectangle.ValidateSide(value, "width");
                this.width = value;
            }
        }

        public override double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Rectangle.ValidateSide(value, "height");
                this.height = value;
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = 2 * (this.Width + this.Height);

                return perimeter;
            }
        }

        public override double Surface
        {
            get
            {
                double surface = this.Width * this.Height;

                return surface;
            }
        }

        private static void ValidateSide(double side, string sideName)
        {
            if (side <= 0)
            {
                string errorMassage = string.Format("Rectangle {0} must be greater than zero!", sideName);
                throw new ArgumentOutOfRangeException(errorMassage);
            }
        }
    }
}
