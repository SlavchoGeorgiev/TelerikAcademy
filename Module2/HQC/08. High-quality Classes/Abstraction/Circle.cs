namespace Abstraction
{
    using System;
    using System.Collections;

    public class Circle : Figure, IFigure
    {
        private double radius = 0;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be greater than zero!");
                }

                this.radius = value;
            }
        }

        public override double Width
        {
            get
            {
                double width = 2 * this.Radius;

                return width;
            }

            set
            {
            }
        }

        public override double Height
        {
            get
            {
                return this.Width;
            }

            set
            {
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = 2 * Math.PI * this.Radius;

                return perimeter;
            }
        }

        public override double Surface
        {
            get
            {
                double surface = Math.PI * this.Radius * this.Radius;

                return surface;
            }
        }
    }
}
