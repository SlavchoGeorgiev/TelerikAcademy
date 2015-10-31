namespace ClassSize
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Rotates instance of class Size.
        /// </summary>
        /// <param name="size">Type size.</param>
        /// <param name="angle">An angle, measured in radians.</param>
        /// <returns>Returns new instance of Size, the result after rotation.</returns>
        public static Size GetRotatedSize(Size size, double angle)
        {
            var newWidth = Math.Abs(Math.Cos(angle) * size.Width) + Math.Abs(Math.Sin(angle) * size.Height);
            var newHeigth = Math.Abs(Math.Sin(angle) * size.Width) + Math.Abs(Math.Cos(angle) * size.Height);

            return new Size(newWidth, newHeigth);
        }
    }
}
