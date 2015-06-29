using System;

namespace GSMlib
{
    public class Display
    {
        private double? size;
        private double? numberOfColors;
        public Display()
        {
            this.Size = null;
            this.NumberOfColors = null;
        }
        public Display(double? size)
        {
            this.Size = size;
            this.NumberOfColors = null;
        }
        public Display(double? size, double? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > 0 || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Size should be positive number!");
                }
            }
        }
        public double? NumberOfColors 
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value >= 2 || value == null)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number of colors should be bigger than 2");
                }
            }
        }
    }
}
