namespace P1Shapes
{
    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
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
        
        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("{0} width: {1:F2}, height {2:F2}.", this.GetType().Name, this.Width, this.Height);
        }
    }
}
